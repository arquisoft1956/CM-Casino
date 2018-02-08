Imports System
Imports System.Diagnostics
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Threading

Public Module MsgBoxUtil

    '#Region "Interoperabilidad"
    '    ''' <summary>Delegado para pasar funciones coom parametro a llmados de la api</summary>
    '    Private Delegate Function EnumWindowDelegate(ByVal handler As IntPtr, ByVal longPointer As IntPtr) As Boolean

    '    ''' <summary>Establece el texto de una ventana</summary>
    '    <DllImport("user32.dll")> _
    '    Private Shared Function SetWindowText(ByVal handler As IntPtr, ByVal texto As String) As Boolean
    '    End Function

    '    ''' <summary>Obtiene el nombre de la clase de una ventana</summary>
    '    <DllImport("user32.dll")> _
    '    Private Shared Function GetClassName(ByVal handler As IntPtr, ByVal nombre As StringBuilder, ByVal tamañoMaximo As Integer) As Integer
    '    End Function

    '    ''' <summary>Realiza un listado de las ventanas hijas y por cada una ejecuta un callback asociado</summary>
    '    <DllImport("user32.dll")> _
    '    Private Shared Function EnumChildWindows(ByVal handler As IntPtr, ByVal callback As EnumWindowDelegate, ByVal longPointer As IntPtr) As Boolean
    '    End Function

    '    ''' <summary>Realiza un listado de las ventanas del hilo actual por cada una ejecuta un callback asociado</summary>
    '    <DllImport("user32.dll")> _
    '    Private Shared Function EnumThreadWindows(ByVal threadID As Integer, ByVal callback As EnumWindowDelegate, ByVal longPointer As IntPtr) As Boolean
    '    End Function

    '    ''' <summary>Obtiene el ID del hilo actual</summary>
    '    <DllImport("kernel32.dll")> _
    '    Private Shared Function GetCurrentThreadId() As Integer
    '    End Function

    '    ''' <summary>Obtiene el handler de una ventana</summary>
    '    <DllImport("user32.dll")> _
    '    Private Shared Function FindWindow(ByVal ClassName As String, ByVal WindowName As String) As IntPtr
    '    End Function

    '    ''' <summary>Obtiene el thread id del  hilo donde se ejecuta una ventana</summary>
    '    <DllImport("user32.dll", SetLastError:=True)> _
    '    Private Shared Function GetWindowThreadProcessId(ByVal hWnd As IntPtr, ByVal lpdwProcessId As Integer) As Integer
    '    End Function

    '    ''' <summary>Realiza un listado de las ventanas y por cada una ejecuta un callback asociado</summary>
    '    <DllImport("user32.dll")> _
    '    Private Shared Function EnumWindows(ByVal lpEnumFunc As EnumWindowDelegate, ByVal lParam As IntPtr) As Boolean
    '    End Function

    '    ''' <summary>Destruye la referencia a una ventana</summary>
    '    <DllImport("user32.dll")> _
    '    Private Shared Function DestroyWindow(ByVal hwnd As IntPtr) As Boolean
    '    End Function
    '#End Region


    '#Region "Objetos locales"
    '    ''' <summary>Array que almacena los textosque se colocaran a cada uno de los botones del msgbox</summary>
    '    Private Shared textoBotones As String()
    '    ''' <summary>Indica cual de los botones se esta actualizando</summary>
    '    Private Shared indiceTexto As Integer
    '    ''' <summary>Delegado para llamar el proceso de cambio de texto de manera asincrona, se usa en aplicaciones no forms</summary>
    '    Private Shared EsperarYCambiarMsgBoxWC As New WaitCallback(EsperarYCambiarMsgBox)
    '    ''' <summary>Delegado para buscar e iniciar el proceso de cambio de textos en aplicaciones forms</summary>
    '    Private Delegate Sub BuscarMsgBoxDelegate()
    '    ''' <summary>Handler del ultimo message box modificado</summary>
    '    Private Shared globalHandler As IntPtr
    '#End Region


    '#Region "Constantes"
    '    ''' <summary>Nombre de la clase de la ventana de un messagebox</summary>
    '    Private Const MBOX_CLASSNAME As String = "#32770"
    '    ''' <summary>Nombre de la clase de la ventana de un boton</summary>
    '    Private Const BUTTON_CLASSNAME As String = "Button"
    '    ''' <summary>Número de reintentos de hallar un messagebox en el listado de ventanas
    '    ''' , se usa en aplicaciones no forms</summary>
    '    Private Const CICLOS_REINTENTO As Integer = 2
    '    ''' <summary>Tiempo de espera entre reintentos de hallar un messagebox en el listadod de ventanas
    '    ''' , se usa en aplicaciones no forms</summary>
    '    Private Const TIEMPO_REINTENTO As Integer = 50
    '    ''' <summary>Capacidad máxima para StringBuilders</summary>
    '    Private Const STRING_BUILDER_CAPACITY As Integer = 256
    '#End Region


    '#Region "Métodos Públicos"

    '    ''' <summary>
    '    ''' Modifica el texto de los botones de un messagebox
    '    ''' </summary>
    '    ''' <param name="textoBotones">lista de labels para los botones</param>
    '    ''' <remarks>Internamente se llama a EsperarYCambiarMsgBoxWC
    '    ''' que es un WaitCallBack que llama a EsperarYCambiarMsgBox</remarks>
    '    Public Shared Sub HackMessageBox(ByVal ParamArray textoBotones As String())
    '        guardar referencia global a la lista
    '        MsgBoxUtil.textoBotones = textoBotones
    '        Si hay al menos una forma... se debe trabajar como aplicación forms
    '        If Application.OpenForms.Count > 0 Then
    '            Se llama el delegado desde el hilo actual de forms
    '            Application.OpenForms(0).BeginInvoke(New BuscarMsgBoxDelegate(BuscaMessageBox))
    '        Else
    '            sino, se debe presuponer que la instancia del msgbox no ha sido creada
    '                         * y hay que esperar a que se cree
    '            Llamado(asincrono)
    '            ThreadPool.QueueUserWorkItem(EsperarYCambiarMsgBoxWC)
    '        End If
    '    End Sub

    '    ''' <summary>Destruye el hack aplicado</summary>
    '    Public Shared Sub UnHackMessageBox()
    '        destruye la ventahna de msgbox a la qu se le aplico el hack
    '        windows se encarga de revivir la instancia
    '        DestroyWindow(MsgBoxUtil.globalHandler)
    '    End Sub

    '#End Region


    '#Region "Métodos Privados"

    '    ''' <summary>Wrapper para simplificar el llamado a EnumThreadWindows desde HackMessageBox</summary>
    '    Private Shared Sub BuscaMessageBox()
    '        EnumThreadWindows(GetCurrentThreadId(), AddressOf ProcesaMessageBoxEnForms, IntPtr.Zero)
    '    End Sub

    '    ''' <summary>
    '    ''' Busca las ventanas que sean messagebox y que pertenezcan al proceso actual
    '    ''' sino encuentra ninguna realiza algunos reintentos cada cierto tiempo
    '    ''' </summary>
    '    ''' <param name="stateInfo">no se usa, neceario para crear un waitcallback y asi realizar ejecución desde el threadpool</param>
    '    ''' <remarks>Esta funcion es util cuando no se busca el messagebox desde forms, 
    '    ''' ya que se debe esperar a que la instancia estatica del messagebox sea creada
    '    ''' por lo cual se prevee hacer algunos intentos de busqueda</remarks>
    '    Private Shared Sub EsperarYCambiarMsgBox(ByVal stateInfo As [Object])
    '        Dim contador As Integer = CICLOS_REINTENTO
    '        Do
    '            sino encontro, espera un poco y busca de nuevo
    '            EnumWindows retorna true si enumero las ventanas hasta el final
    '            If EnumWindows(AddressOf ProcesaMessageBoxEnOtros, IntPtr.Zero) Then
    '                Thread.Sleep(TIEMPO_REINTENTO)
    '            Else
    '                si encontro se sale del ciclo
    '                Exit Do

    '            End If
    '        Loop While System.Threading.Interlocked.Decrement(contador) > 0
    '    End Sub

    '    ''' <summary>
    '    ''' Determina si el handler pasado es un messagebox, 
    '    ''' si es así inicia el proceso de modificacion de texto de los botones
    '    ''' </summary>
    '    ''' <param name="handler">manejador de la ventana</param>
    '    ''' <param name="longPointer">no se usa, pero se requiere como signature de delegado</param>
    '    ''' <returns>Si el handle pasado no es un MessageBox devuelve true, false de lo contrario</returns>
    '    Private Shared Function ProcesaMessageBoxEnForms(ByVal handler As IntPtr, ByVal longPointer As IntPtr) As Boolean
    '        almacenar nombre de la clase
    '        Dim nombreClase As New StringBuilder(STRING_BUILDER_CAPACITY)
    '        GetClassName(handler, nombreClase, nombreClase.Capacity)

    '        Si no es un MessageBox...
    '        If nombreClase.ToString() <> MBOX_CLASSNAME Then
    '            Return True
    '        Else
    '            Inicializar indice del arreglo
    '            indiceTexto = 0
    '            Buscar y cambiar Botones del MessageBox
    '            EnumChildWindows(handler, AddressOf CambiaTextoBotonMessageBox, IntPtr.Zero)
    '            guardar handler del MessageBox
    '            MsgBoxUtil.globalHandler = handler
    '            Return False
    '        End If
    '    End Function

    '    ''' <summary>
    '    ''' Determina si el handler pasado es un messagebox, 
    '    ''' si es así inicia el proceso de modificacion de texto de los botones
    '    ''' </summary>
    '    ''' <param name="handler">manejador de la ventana</param>
    '    ''' <param name="longPointer">no se usa, pero se requiere como signature de delegado</param>
    '    ''' <returns>Si el handle pasado no es un MessageBox devuelve true, false de lo contrario</returns>
    '    ''' <remarks>Util para llamar cuando el proceso que hace el llamado no es forms</remarks>
    '    Private Shared Function ProcesaMessageBoxEnOtros(ByVal handler As IntPtr, ByVal longPointer As IntPtr) As Boolean
    '        almacenar nombre de la clase
    '        Dim nombreClase As New StringBuilder(STRING_BUILDER_CAPACITY)
    '        GetClassName(handler, nombreClase, nombreClase.Capacity)

    '        Si no es un MessageBox...
    '        If nombreClase.ToString() <> MBOX_CLASSNAME Then
    '            Return True
    '        Else
    '            Determinar el id de proceso actual
    '            Dim pid As Integer = Process.GetCurrentProcess().Id
    '            Id del proceso de la ventana donde se ejecuta el 
    '                         * MesasgeBox al cual pertenece el handler

    '            Dim wpid As Integer
    '            GetWindowThreadProcessId(handler, wpid)

    '            Si son del mismo proceso se procede
    '            a realizar la modificacion de textos
    '            If wpid = pid Then
    '                Inicializar indice del arreglo
    '                indiceTexto = 0
    '                Buscar y cambiar Botones del MessageBox
    '                EnumChildWindows(handler, AddressOf CambiaTextoBotonMessageBox, IntPtr.Zero)
    '                guardar handler del MessageBox
    '                MsgBoxUtil.globalHandler = handler
    '                Return False
    '            Else
    '                Return True
    '            End If
    '        End If
    '    End Function

    '    ''' <summary>
    '    ''' Cambia el texto del boton recibido como parámetro de acuerdo al listado
    '    ''' de valores iniciales al llamr a HackMessageBox
    '    ''' </summary>
    '    ''' <param name="handler">Manejador del boton</param>
    '    ''' <param name="longPointer">no se usa, pero se requiere como signature de los delegados</param>
    '    ''' <returns>siempre true</returns>
    '    Private Shared Function CambiaTextoBotonMessageBox(ByVal handler As IntPtr, ByVal longPointer As IntPtr) As Boolean
    '        almacenar nombre de la clase
    '        Dim nombreClase As New StringBuilder(STRING_BUILDER_CAPACITY)
    '        GetClassName(handler, nombreClase, nombreClase.Capacity)

    '        Si el handler es de un boton se modifica el texto
    '        If nombreClase.ToString() = BUTTON_CLASSNAME AndAlso indiceTexto < textoBotones.Length Then
    '            SetWindowText(handler, textoBotones(indiceTexto))
    '            indiceTexto += 1
    '        End If
    '        Return True
    '    End Function
    '#End Region


End Module