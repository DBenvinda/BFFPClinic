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
        Me.aceArtigos = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.aceDocs = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.aceEntidades = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.aceEspecialidades = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.aceIVA = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.aceMarcacoes = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.aceSalas = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AceSeries = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.aceTipos_Doc = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.aceTipos_Marcacao = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.aceTipos_Pagamento = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.aceLogout = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.aceSair = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.FluentDesignFormControl1 = New DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl()
        Me.lblUtilizador = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.f = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement4 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.AccordionControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FluentDesignFormControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FluentDesignFormControl1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FluentDesignFormContainer1
        '
        Me.FluentDesignFormContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FluentDesignFormContainer1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.FluentDesignFormContainer1.Appearance.Options.UseBackColor = True
        Me.FluentDesignFormContainer1.Location = New System.Drawing.Point(250, 37)
        Me.FluentDesignFormContainer1.Name = "FluentDesignFormContainer1"
        Me.FluentDesignFormContainer1.Size = New System.Drawing.Size(652, 573)
        Me.FluentDesignFormContainer1.TabIndex = 0
        '
        'AccordionControl1
        '
        Me.AccordionControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.AccordionControl1.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.aceArtigos, Me.aceDocs, Me.aceEntidades, Me.aceEspecialidades, Me.aceIVA, Me.aceMarcacoes, Me.aceSalas, Me.AceSeries, Me.aceTipos_Doc, Me.aceTipos_Marcacao, Me.aceTipos_Pagamento, Me.aceLogout, Me.aceSair})
        Me.AccordionControl1.Location = New System.Drawing.Point(0, 31)
        Me.AccordionControl1.Name = "AccordionControl1"
        Me.AccordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch
        Me.AccordionControl1.Size = New System.Drawing.Size(250, 579)
        Me.AccordionControl1.TabIndex = 1
        Me.AccordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu
        '
        'aceArtigos
        '
        Me.aceArtigos.Appearance.Default.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aceArtigos.Appearance.Default.Options.UseFont = True
        Me.aceArtigos.Height = 60
        Me.aceArtigos.ImageOptions.Image = CType(resources.GetObject("aceArtigos.ImageOptions.Image"), System.Drawing.Image)
        Me.aceArtigos.Name = "aceArtigos"
        Me.aceArtigos.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.aceArtigos.Text = "Artigos"
        '
        'aceDocs
        '
        Me.aceDocs.Appearance.Default.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aceDocs.Appearance.Default.Options.UseFont = True
        Me.aceDocs.Height = 60
        Me.aceDocs.ImageOptions.Image = CType(resources.GetObject("aceDocs.ImageOptions.Image"), System.Drawing.Image)
        Me.aceDocs.Name = "aceDocs"
        Me.aceDocs.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.aceDocs.Text = "Documentos"
        '
        'aceEntidades
        '
        Me.aceEntidades.Appearance.Default.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aceEntidades.Appearance.Default.Options.UseFont = True
        Me.aceEntidades.Expanded = True
        Me.aceEntidades.HeaderTemplate.AddRange(New DevExpress.XtraBars.Navigation.HeaderElementInfo() {New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Left), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)})
        Me.aceEntidades.Height = 60
        Me.aceEntidades.ImageOptions.Image = CType(resources.GetObject("aceEntidades.ImageOptions.Image"), System.Drawing.Image)
        Me.aceEntidades.Name = "aceEntidades"
        Me.aceEntidades.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.aceEntidades.Text = "Entidades"
        '
        'aceEspecialidades
        '
        Me.aceEspecialidades.Appearance.Default.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aceEspecialidades.Appearance.Default.Options.UseFont = True
        Me.aceEspecialidades.Height = 60
        Me.aceEspecialidades.ImageOptions.Image = CType(resources.GetObject("aceEspecialidades.ImageOptions.Image"), System.Drawing.Image)
        Me.aceEspecialidades.Name = "aceEspecialidades"
        Me.aceEspecialidades.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.aceEspecialidades.Text = "Especialidades"
        '
        'aceIVA
        '
        Me.aceIVA.Appearance.Default.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aceIVA.Appearance.Default.Options.UseFont = True
        Me.aceIVA.Height = 60
        Me.aceIVA.ImageOptions.Image = CType(resources.GetObject("aceIVA.ImageOptions.Image"), System.Drawing.Image)
        Me.aceIVA.Name = "aceIVA"
        Me.aceIVA.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.aceIVA.Text = "IVA"
        '
        'aceMarcacoes
        '
        Me.aceMarcacoes.Appearance.Default.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aceMarcacoes.Appearance.Default.Options.UseFont = True
        Me.aceMarcacoes.Height = 60
        Me.aceMarcacoes.ImageOptions.Image = CType(resources.GetObject("aceMarcacoes.ImageOptions.Image"), System.Drawing.Image)
        Me.aceMarcacoes.Name = "aceMarcacoes"
        Me.aceMarcacoes.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.aceMarcacoes.Text = "Marcações"
        '
        'aceSalas
        '
        Me.aceSalas.Appearance.Default.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aceSalas.Appearance.Default.Options.UseFont = True
        Me.aceSalas.Height = 60
        Me.aceSalas.ImageOptions.Image = CType(resources.GetObject("aceSalas.ImageOptions.Image"), System.Drawing.Image)
        Me.aceSalas.Name = "aceSalas"
        Me.aceSalas.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.aceSalas.Text = "Salas"
        '
        'AceSeries
        '
        Me.AceSeries.Appearance.Default.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AceSeries.Appearance.Default.Options.UseFont = True
        Me.AceSeries.Height = 60
        Me.AceSeries.ImageOptions.Image = CType(resources.GetObject("AceSeries.ImageOptions.Image"), System.Drawing.Image)
        Me.AceSeries.Name = "AceSeries"
        Me.AceSeries.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AceSeries.Text = "Series"
        '
        'aceTipos_Doc
        '
        Me.aceTipos_Doc.Appearance.Default.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aceTipos_Doc.Appearance.Default.Options.UseFont = True
        Me.aceTipos_Doc.Height = 60
        Me.aceTipos_Doc.ImageOptions.Image = CType(resources.GetObject("aceTipos_Doc.ImageOptions.Image"), System.Drawing.Image)
        Me.aceTipos_Doc.Name = "aceTipos_Doc"
        Me.aceTipos_Doc.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.aceTipos_Doc.Text = "Tipos_Doc"
        '
        'aceTipos_Marcacao
        '
        Me.aceTipos_Marcacao.Appearance.Default.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aceTipos_Marcacao.Appearance.Default.Options.UseFont = True
        Me.aceTipos_Marcacao.Height = 60
        Me.aceTipos_Marcacao.ImageOptions.Image = CType(resources.GetObject("aceTipos_Marcacao.ImageOptions.Image"), System.Drawing.Image)
        Me.aceTipos_Marcacao.Name = "aceTipos_Marcacao"
        Me.aceTipos_Marcacao.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.aceTipos_Marcacao.Text = "Tipos de marcacao"
        '
        'aceTipos_Pagamento
        '
        Me.aceTipos_Pagamento.Appearance.Default.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aceTipos_Pagamento.Appearance.Default.Options.UseFont = True
        Me.aceTipos_Pagamento.Height = 60
        Me.aceTipos_Pagamento.ImageOptions.Image = CType(resources.GetObject("aceTipos_Pagamento.ImageOptions.Image"), System.Drawing.Image)
        Me.aceTipos_Pagamento.Name = "aceTipos_Pagamento"
        Me.aceTipos_Pagamento.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.aceTipos_Pagamento.Text = "Tipos de pagamento"
        '
        'aceLogout
        '
        Me.aceLogout.Appearance.Default.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.aceLogout.Appearance.Default.Options.UseFont = True
        Me.aceLogout.ImageOptions.Image = CType(resources.GetObject("aceLogout.ImageOptions.Image"), System.Drawing.Image)
        Me.aceLogout.Name = "aceLogout"
        Me.aceLogout.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.aceLogout.Text = "Logout"
        '
        'aceSair
        '
        Me.aceSair.Appearance.Default.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aceSair.Appearance.Default.Options.UseFont = True
        Me.aceSair.ImageOptions.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.backward_32x32
        Me.aceSair.Name = "aceSair"
        Me.aceSair.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.aceSair.Text = "Sair"
        '
        'FluentDesignFormControl1
        '
        Me.FluentDesignFormControl1.Controls.Add(Me.lblUtilizador)
        Me.FluentDesignFormControl1.Controls.Add(Me.Label1)
        Me.FluentDesignFormControl1.FluentDesignForm = Me
        Me.FluentDesignFormControl1.Location = New System.Drawing.Point(0, 0)
        Me.FluentDesignFormControl1.Name = "FluentDesignFormControl1"
        Me.FluentDesignFormControl1.Size = New System.Drawing.Size(1452, 31)
        Me.FluentDesignFormControl1.TabIndex = 2
        Me.FluentDesignFormControl1.TabStop = False
        '
        'lblUtilizador
        '
        Me.lblUtilizador.AutoSize = True
        Me.lblUtilizador.BackColor = System.Drawing.Color.Transparent
        Me.lblUtilizador.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblUtilizador.Location = New System.Drawing.Point(810, 9)
        Me.lblUtilizador.Name = "lblUtilizador"
        Me.lblUtilizador.Size = New System.Drawing.Size(0, 21)
        Me.lblUtilizador.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(713, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Utilizador:"
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
        Me.AccordionControlElement4.Name = "AccordionControlElement4"
        Me.AccordionControlElement4.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement4.Text = "Element5"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(894, 77)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(558, 533)
        Me.Panel1.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.logo_Original_Fundo_maisclaro
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(558, 533)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frmMain
        '
        Me.Appearance.BackColor = System.Drawing.Color.Gainsboro
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1452, 610)
        Me.ControlContainer = Me.FluentDesignFormContainer1
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FluentDesignFormContainer1)
        Me.Controls.Add(Me.AccordionControl1)
        Me.Controls.Add(Me.FluentDesignFormControl1)
        Me.FluentDesignFormControl = Me.FluentDesignFormControl1
        Me.IconOptions.Image = Global.PAP_G2_BFFPclinic_01_Rafael.My.Resources.Resources.logo
        Me.Name = "frmMain"
        Me.NavigationControl = Me.AccordionControl1
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BFFP Clinic - Back Office"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AccordionControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FluentDesignFormControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FluentDesignFormControl1.ResumeLayout(False)
        Me.FluentDesignFormControl1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FluentDesignFormContainer1 As DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer
    Friend WithEvents AccordionControl1 As DevExpress.XtraBars.Navigation.AccordionControl
    Friend WithEvents FluentDesignFormControl1 As DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl
    Friend WithEvents aceEntidades As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents f As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents aceSair As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents aceArtigos As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents aceEspecialidades As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents aceIVA As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents aceMarcacoes As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents aceSalas As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AceSeries As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents aceTipos_Doc As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents aceTipos_Marcacao As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents aceTipos_Pagamento As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement4 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents aceDocs As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents aceLogout As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents lblUtilizador As Label
    Friend WithEvents Label1 As Label
End Class
