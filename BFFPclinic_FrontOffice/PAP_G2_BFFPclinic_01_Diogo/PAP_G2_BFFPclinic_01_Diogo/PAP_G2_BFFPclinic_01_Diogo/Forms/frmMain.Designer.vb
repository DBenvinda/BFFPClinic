<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.FluentDesignFormContainer1 = New DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer()
        Me.AccordionControl1 = New DevExpress.XtraBars.Navigation.AccordionControl()
        Me.grupo_Consultas = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.Grupo_Operacoes = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.grupo_exames = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.grupo_Faturaçao = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.aceFatura = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.aceEntidades = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.aceLogout = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.acSair = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.FluentDesignFormControl1 = New DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblUtilizador = New System.Windows.Forms.Label()
        Me.f = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement4 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.aceExames = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.aceConsultas = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement2 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        CType(Me.AccordionControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FluentDesignFormControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FluentDesignFormControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FluentDesignFormContainer1
        '
        Me.FluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FluentDesignFormContainer1.Location = New System.Drawing.Point(333, 31)
        Me.FluentDesignFormContainer1.Margin = New System.Windows.Forms.Padding(4)
        Me.FluentDesignFormContainer1.Name = "FluentDesignFormContainer1"
        Me.FluentDesignFormContainer1.Size = New System.Drawing.Size(922, 717)
        Me.FluentDesignFormContainer1.TabIndex = 0
        '
        'AccordionControl1
        '
        Me.AccordionControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.AccordionControl1.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.grupo_Consultas, Me.Grupo_Operacoes, Me.grupo_exames, Me.grupo_Faturaçao, Me.aceEntidades, Me.aceLogout, Me.acSair})
        Me.AccordionControl1.Location = New System.Drawing.Point(0, 31)
        Me.AccordionControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.AccordionControl1.Name = "AccordionControl1"
        Me.AccordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch
        Me.AccordionControl1.Size = New System.Drawing.Size(333, 717)
        Me.AccordionControl1.TabIndex = 1
        Me.AccordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu
        '
        'grupo_Consultas
        '
        Me.grupo_Consultas.Appearance.Default.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupo_Consultas.Appearance.Default.Options.UseFont = True
        Me.grupo_Consultas.ImageOptions.Image = CType(resources.GetObject("grupo_Consultas.ImageOptions.Image"), System.Drawing.Image)
        Me.grupo_Consultas.Name = "grupo_Consultas"
        Me.grupo_Consultas.Tag = "TM001"
        Me.grupo_Consultas.Text = "Consultas"
        '
        'Grupo_Operacoes
        '
        Me.Grupo_Operacoes.Appearance.Default.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grupo_Operacoes.Appearance.Default.Options.UseFont = True
        Me.Grupo_Operacoes.Expanded = True
        Me.Grupo_Operacoes.ImageOptions.SvgImage = CType(resources.GetObject("Grupo_Operacoes.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.Grupo_Operacoes.Name = "Grupo_Operacoes"
        Me.Grupo_Operacoes.Tag = "TM002"
        Me.Grupo_Operacoes.Text = "Operações"
        '
        'grupo_exames
        '
        Me.grupo_exames.Appearance.Default.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupo_exames.Appearance.Default.Options.UseFont = True
        Me.grupo_exames.Expanded = True
        Me.grupo_exames.ImageOptions.Image = CType(resources.GetObject("grupo_exames.ImageOptions.Image"), System.Drawing.Image)
        Me.grupo_exames.Name = "grupo_exames"
        Me.grupo_exames.Tag = "TM003"
        Me.grupo_exames.Text = "Exames"
        '
        'grupo_Faturaçao
        '
        Me.grupo_Faturaçao.Appearance.Default.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupo_Faturaçao.Appearance.Default.Options.UseFont = True
        Me.grupo_Faturaçao.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.aceFatura})
        Me.grupo_Faturaçao.ImageOptions.Image = CType(resources.GetObject("grupo_Faturaçao.ImageOptions.Image"), System.Drawing.Image)
        Me.grupo_Faturaçao.Name = "grupo_Faturaçao"
        Me.grupo_Faturaçao.Text = "Faturação"
        '
        'aceFatura
        '
        Me.aceFatura.ImageOptions.Image = CType(resources.GetObject("aceFatura.ImageOptions.Image"), System.Drawing.Image)
        Me.aceFatura.Name = "aceFatura"
        Me.aceFatura.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.aceFatura.Text = "Faturação"
        '
        'aceEntidades
        '
        Me.aceEntidades.Appearance.Default.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.aceEntidades.Appearance.Default.Options.UseFont = True
        Me.aceEntidades.HeaderTemplate.AddRange(New DevExpress.XtraBars.Navigation.HeaderElementInfo() {New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Left), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)})
        Me.aceEntidades.ImageOptions.Image = CType(resources.GetObject("aceEntidades.ImageOptions.Image"), System.Drawing.Image)
        Me.aceEntidades.Name = "aceEntidades"
        Me.aceEntidades.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.aceEntidades.Text = "Entidades"
        '
        'aceLogout
        '
        Me.aceLogout.Appearance.Default.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.aceLogout.Appearance.Default.Options.UseFont = True
        Me.aceLogout.ImageOptions.Image = CType(resources.GetObject("aceLogout.ImageOptions.Image"), System.Drawing.Image)
        Me.aceLogout.Name = "aceLogout"
        Me.aceLogout.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.aceLogout.Text = "LogOut"
        '
        'acSair
        '
        Me.acSair.Appearance.Default.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.acSair.Appearance.Default.Options.UseFont = True
        Me.acSair.ImageOptions.Image = CType(resources.GetObject("AccordionControlElement1.ImageOptions.Image"), System.Drawing.Image)
        Me.acSair.Name = "acSair"
        Me.acSair.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.acSair.Text = "Sair"
        '
        'FluentDesignFormControl1
        '
        Me.FluentDesignFormControl1.Controls.Add(Me.Label2)
        Me.FluentDesignFormControl1.Controls.Add(Me.LblUtilizador)
        Me.FluentDesignFormControl1.FluentDesignForm = Me
        Me.FluentDesignFormControl1.Location = New System.Drawing.Point(0, 0)
        Me.FluentDesignFormControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.FluentDesignFormControl1.Name = "FluentDesignFormControl1"
        Me.FluentDesignFormControl1.Size = New System.Drawing.Size(1255, 31)
        Me.FluentDesignFormControl1.TabIndex = 2
        Me.FluentDesignFormControl1.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(777, 8)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Utilizador:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblUtilizador
        '
        Me.LblUtilizador.BackColor = System.Drawing.Color.Transparent
        Me.LblUtilizador.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUtilizador.Location = New System.Drawing.Point(863, 8)
        Me.LblUtilizador.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblUtilizador.Name = "LblUtilizador"
        Me.LblUtilizador.Size = New System.Drawing.Size(152, 29)
        Me.LblUtilizador.TabIndex = 0
        Me.LblUtilizador.Text = "Label1"
        Me.LblUtilizador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'f
        '
        Me.f.ImageOptions.SvgImage = CType(resources.GetObject("f.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.f.Name = "f"
        Me.f.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.f.Text = "Sair"
        '
        'AccordionControlElement4
        '
        Me.AccordionControlElement4.Expanded = True
        Me.AccordionControlElement4.Name = "AccordionControlElement4"
        Me.AccordionControlElement4.Text = "Marcações"
        '
        'aceExames
        '
        Me.aceExames.Name = "aceExames"
        Me.aceExames.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.aceExames.Text = "Exames"
        '
        'aceConsultas
        '
        Me.aceConsultas.Name = "aceConsultas"
        Me.aceConsultas.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.aceConsultas.Text = "Consultas"
        '
        'AccordionControlElement2
        '
        Me.AccordionControlElement2.ImageOptions.Image = CType(resources.GetObject("AccordionControlElement2.ImageOptions.Image"), System.Drawing.Image)
        Me.AccordionControlElement2.Name = "AccordionControlElement2"
        Me.AccordionControlElement2.Text = "Marcações"
        '
        'frmMain
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1255, 748)
        Me.ControlContainer = Me.FluentDesignFormContainer1
        Me.Controls.Add(Me.FluentDesignFormContainer1)
        Me.Controls.Add(Me.AccordionControl1)
        Me.Controls.Add(Me.FluentDesignFormControl1)
        Me.FluentDesignFormControl = Me.FluentDesignFormControl1
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMain"
        Me.NavigationControl = Me.AccordionControl1
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AccordionControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FluentDesignFormControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FluentDesignFormControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FluentDesignFormContainer1 As DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer
    Friend WithEvents AccordionControl1 As DevExpress.XtraBars.Navigation.AccordionControl
    Friend WithEvents FluentDesignFormControl1 As DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl
    Friend WithEvents aceEntidades As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents grupo_Faturaçao As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents aceFatura As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents f As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents aceLogout As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement4 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents aceExames As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents aceConsultas As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents grupo_Consultas As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents grupo_exames As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement2 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents Grupo_Operacoes As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents Label2 As Label
    Friend WithEvents LblUtilizador As Label
    Friend WithEvents acSair As DevExpress.XtraBars.Navigation.AccordionControlElement
End Class
