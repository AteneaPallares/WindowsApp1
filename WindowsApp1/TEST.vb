Public Class TEST
    Public valores(41) As Double


    Private Sub TEST_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Form1.Show()
        Form1.Hide()
        Form1.Enabled = False
        Form1.Enabled = True
        Panel1.AutoScroll = True
        'Panel2.AutoScroll = True


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox30_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox43_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles unoa.CheckedChanged

    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label27_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox27_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox26_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged

    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged

    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged

    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged

    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel1_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub


    Private Sub emviar_Click(sender As Object, e As EventArgs) Handles emviar.Click
        Dim medicociruganopartero As Double
        Dim ingenieriaindustrial As Double
        Dim licenciaturaennegociosinternacionales As Double
        Dim medicaveterinario As Double
        Dim licenciaturaenderecho As Double
        Dim licenciaturaenarquitectura As Double
        Dim licenciaturaenenfermeria As Double
        Dim ingenieriaquimica As Double
        Dim licenciaturaenadministracion As Double
        Dim licenciaturaendisenoindustrial As Double
        Dim ingenieriacivil As Double
        Dim licenciaturaenmercadotecnia As Double
        Dim ingenieriaeninformatica As Double
        Dim ingenieriaenrobotica As Double
        Dim licenciaturaencontaduriapublica As Double
        Dim licenciaturaenrecursoshumanos As Double
        Dim licenciaturaenpscologia As Double
        Dim licenciaturaentrabajosocial As Double
        Dim tecnivosuperioruniversitarioenterapiafisica As Double
        Dim licenciaturaenculturafisicaydeporte As Double
        Dim licenciaturaencriminologia As Double
        Dim licenciaturaencienciasforenses As Double
        Dim ingenieriaenlogisticasytransportes As Double
        Dim licenciaturaendisenodeinteriores As Double
        Dim licenciaturaenartesplasticas As Double
        Dim licenciaturaennutricion As Double
        Dim ingenieriaencomputacion As Double
        Dim licenciaturaengeografia As Double
        Dim licenciaturaenhistoria As Double
        Dim licenciaturaenqfb As Double
        Dim licenciaturaenbiologia As Double
        Dim licenciaturaquimica As Double
        Dim docentedeprimaria As Double
        Dim docentepreescolar As Double
        Dim periodismo As Double
        Dim piloto As Double
        Dim militar As Double
        Dim licenciaturaenmedicodentista As Double
        Dim ingenieriaagronomia As Double
        Dim licenciaturaengastronomia As Double
        Dim licenciaturaendiseñodemodas As Double
        'PREGUNTA 1
        If unoa.Checked Then
            licenciaturaquimica += 1
            licenciaturaenqfb += 1
            licenciaturaenbiologia += 1
            licenciaturaenhistoria += 1
            licenciaturaengeografia += 1
            licenciaturaenarquitectura += 1
            tecnivosuperioruniversitarioenterapiafisica += 1
            licenciaturaenculturafisicaydeporte += 1
            licenciaturaendisenodeinteriores += 1
            licenciaturaenartesplasticas += 1
            licenciaturaenmedicodentista += 1
            ingenieriaagronomia += 1
            militar += 1
            piloto += 1
            medicociruganopartero = medicociruganopartero + 1
        End If
        If RadioButton2.Checked Then
            licenciaturaengastronomia += 2
            licenciaturaenderecho += 2
            ingenieriaquimica += 2
            licenciaturaendisenoindustrial += 2
            ingenieriaeninformatica += 2
            ingenieriaenrobotica += 2
            licenciaturaennutricion += 2
            ingenieriaencomputacion += 2
            licenciaturaencienciasforenses += 2
            medicaveterinario += 2


        End If
        If RadioButton3.Checked Then
            ingenieriaindustrial += 3
            licenciaturaenenfermeria += 3
            licenciaturaentrabajosocial += 3
            licenciaturaencriminologia += 3
            ingenieriaenlogisticasytransportes += 3
            docentedeprimaria += 3
            docentepreescolar += 3
            licenciaturaendiseñodemodas += 3
        End If
        If RadioButton4.Checked Then
            licenciaturaennegociosinternacionales += 4
            licenciaturaenadministracion += 4
            ingenieriacivil += 4
            licenciaturaenmercadotecnia += 4
            licenciaturaencontaduriapublica += 4
            licenciaturaenrecursoshumanos += 4
            licenciaturaenpscologia += 4
            periodismo += 4

        End If
        'FIN PREGUNTA 1
        'INICIO PREGUNTA 2
        If RadioButton5.Checked Then
            licenciaturaenqfb += 1
            licenciaturaendiseñodemodas += 1
            licenciaturaenbiologia += 1
            licenciaturaquimica += 1
            licenciaturaengeografia += 1
            licenciaturaenhistoria += 1
            medicociruganopartero += 1
            medicaveterinario += 1
            licenciaturaenenfermeria += 1
            tecnivosuperioruniversitarioenterapiafisica += 1
            licenciaturaenculturafisicaydeporte += 1
            licenciaturaenartesplasticas += 1
            licenciaturaennutricion += 1
            docentedeprimaria += 1
            docentepreescolar += 1
            militar += 1
            licenciaturaenmedicodentista += 1
            ingenieriaagronomia += 1
            licenciaturaengastronomia += 1

        End If
        If RadioButton7.Checked Then
            licenciaturaenderecho += 2
            ingenieriaeninformatica += 2
            licenciaturaenpscologia += 2
            licenciaturaentrabajosocial += 2
            licenciaturaencriminologia += 2
            licenciaturaencienciasforenses += 2
            licenciaturaendisenoindustrial += 2
            periodismo += 2
            piloto += 2

        End If
        If RadioButton8.Checked Then
            licenciaturaenarquitectura += 3
            licenciaturaendisenoindustrial += 3
            ingenieriacivil += 3
            ingenieriaenrobotica += 3
            ingenieriaenlogisticasytransportes += 3
            ingenieriaencomputacion += 3

        End If
        If RadioButton6.Checked Then
            ingenieriaindustrial += 4
            ingenieriaquimica += 4
            licenciaturaenadministracion += 4
            licenciaturaenmercadotecnia += 4
            licenciaturaencontaduriapublica += 4
            licenciaturaenrecursoshumanos += 4
            licenciaturaennegociosinternacionales += 4
        End If
        'FIN PREGUNTA 2
        'INICIO PREGUNTA 3'
        If RadioButton9.Checked Then
            ingenieriaindustrial += 1
            licenciaturaendiseñodemodas += 1
            licenciaturaennegociosinternacionales += 1
            licenciaturaenderecho += 1
            licenciaturaenarquitectura += 1
            licenciaturaenadministracion += 1
            licenciaturaendisenoindustrial += 1
            ingenieriacivil += 1
            licenciaturaenmercadotecnia += 1
            ingenieriaeninformatica += 1
            ingenieriaenrobotica += 1
            licenciaturaencontaduriapublica += 1
            licenciaturaenrecursoshumanos += 1
            ingenieriaenlogisticasytransportes += 1
            licenciaturaendisenodeinteriores += 1
            licenciaturaenartesplasticas += 1
            ingenieriaencomputacion += 1
            licenciaturaengeografia += 1
            licenciaturaenhistoria += 1
            docentedeprimaria += 1
            docentepreescolar += 1
            periodismo += 1
            piloto += 1
            militar += 1
            ingenieriaagronomia += 1
            licenciaturaengastronomia += 1
            ingenieriaquimica += 1
        End If
        If RadioButton11.Checked Then
            licenciaturaquimica += 2
        End If
        If RadioButton12.Checked Then
            licenciaturaenpscologia += 3
            licenciaturaentrabajosocial += 3
            licenciaturaenculturafisicaydeporte += 3
            licenciaturaencriminologia += 3
            licenciaturaenmedicodentista += 3
        End If
        If RadioButton10.Checked Then
            medicociruganopartero += 4
            medicaveterinario += 4
            licenciaturaenenfermeria += 4
            tecnivosuperioruniversitarioenterapiafisica += 4
            licenciaturaencienciasforenses += 4
            licenciaturaennutricion += 4
            licenciaturaenqfb += 4
            licenciaturaenbiologia += 4
        End If
        'FIN PREGUNTA 3'
        'INICIO PREGUNTA 4'
        If RadioButton13.Checked Then
            licenciaturaenpscologia += 1
            licenciaturaentrabajosocial += 1
            licenciaturaenculturafisicaydeporte += 1
            licenciaturaendisenoindustrial += 1
            licenciaturaenartesplasticas += 1
            militar += 1
        End If
        If RadioButton15.Checked Then
            licenciaturaenmercadotecnia += 2
            licenciaturaencriminologia += 2
            licenciaturaencienciasforenses += 2
            ingenieriaenlogisticasytransportes += 2
            ingenieriaagronomia += 2
        End If
        If RadioButton16.Checked Then
            licenciaturaenrecursoshumanos += 3
            licenciaturaendiseñodemodas += 3
            tecnivosuperioruniversitarioenterapiafisica += 3
            licenciaturaennutricion += 3
            docentedeprimaria += 3
            docentepreescolar += 3
            licenciaturaengastronomia += 3
        End If
        If RadioButton14.Checked Then
            medicociruganopartero += 4
            ingenieriaindustrial += 4
            licenciaturaennegociosinternacionales += 4
            medicaveterinario += 4
            licenciaturaenderecho += 4
            licenciaturaenenfermeria += 4
            licenciaturaenarquitectura += 4
            ingenieriaquimica += 4
            licenciaturaenadministracion += 4
            ingenieriaeninformatica += 4
            ingenieriacivil += 4
            ingenieriaenrobotica += 4
            licenciaturaencontaduriapublica += 4
            ingenieriaencomputacion += 4
            licenciaturaengeografia += 4
            licenciaturaenhistoria += 4
            licenciaturaenmedicodentista += 4
            periodismo += 4
            piloto += 4
            licenciaturaquimica += 4
            licenciaturaenqfb += 4
            licenciaturaenbiologia += 4
        End If
        'FIN PREGUNTA 4'
        'INICIO PREGUNTA 5'
        If RadioButton17.Checked Then
            medicaveterinario += 1
            medicociruganopartero += 1
            licenciaturaenartesplasticas += 1
            licenciaturaennutricion += 1
        End If
        If RadioButton19.Checked Then
            licenciaturaendiseñodemodas += 2
            ingenieriaindustrial += 2
            licenciaturaenderecho += 2
            licenciaturaenenfermeria += 2
            licenciaturaenarquitectura += 2
            ingenieriaquimica += 2
            licenciaturaenadministracion += 2
            ingenieriaeninformatica += 2
            ingenieriacivil += 2
            ingenieriaenrobotica += 2
            licenciaturaencontaduriapublica += 2
            ingenieriaencomputacion += 2
            licenciaturaengeografia += 2
            licenciaturaenhistoria += 2
            licenciaturaenmedicodentista += 2
            periodismo += 2
            piloto += 2
            licenciaturaquimica += 2
            licenciaturaenqfb += 2
            licenciaturaenbiologia += 2
            licenciaturaenrecursoshumanos += 2
            tecnivosuperioruniversitarioenterapiafisica += 2
            docentedeprimaria += 2
            docentepreescolar += 2
            licenciaturaenpscologia += 2
            licenciaturaentrabajosocial += 2
            licenciaturaenculturafisicaydeporte += 2
            licenciaturaendisenoindustrial += 2
            licenciaturaenartesplasticas += 2
            militar += 2
            licenciaturaenmercadotecnia += 2
            licenciaturaencriminologia += 2
            licenciaturaencienciasforenses += 2
            ingenieriaenlogisticasytransportes += 2
        End If
        If RadioButton20.Checked Then
            ingenieriaagronomia += 3

        End If
        If RadioButton18.Checked Then
            licenciaturaengastronomia += 4
            licenciaturaennegociosinternacionales += 4
        End If
        'FIN PREGUNTA 5'
        'INICIO PREGUNTA 6'
        If RadioButton21.Checked Then
            medicociruganopartero += 1
            ingenieriaindustrial += 1
            licenciaturaenderecho += 1
            licenciaturaenarquitectura += 1
            licenciaturaenenfermeria += 1
            licenciaturaenadministracion += 1
            licenciaturaendisenodeinteriores += 1
            ingenieriacivil += 1
            licenciaturaenmercadotecnia += 1
            ingenieriaeninformatica += 1
            ingenieriaenrobotica += 1
            licenciaturaencontaduriapublica += 1
            licenciaturaenrecursoshumanos += 1
            licenciaturaentrabajosocial += 1
            licenciaturaencriminologia += 1
            ingenieriaenlogisticasytransportes += 1
            licenciaturaenartesplasticas += 1
            ingenieriaencomputacion += 1
            licenciaturaenhistoria += 1
            docentedeprimaria += 1
            docentepreescolar += 1
            periodismo += 1
            piloto += 1
            militar += 1
            licenciaturaenmedicodentista += 1
        End If
        If RadioButton23.Checked Then
            licenciaturaendiseñodemodas += 2
            licenciaturaennegociosinternacionales += 2
            ingenieriaquimica += 2
            licenciaturaenpscologia += 2
            tecnivosuperioruniversitarioenterapiafisica += 2
            licenciaturaencienciasforenses += 2
            licenciaturaengastronomia += 2
        End If
        If RadioButton22.Checked Then
            licenciaturaquimica += 3
            medicaveterinario += 3
            licenciaturaenculturafisicaydeporte += 3
            licenciaturaennutricion += 3
        End If
        If RadioButton22.Checked Then
            licenciaturaenbiologia += 4
            licenciaturaengeografia += 4
            licenciaturaenqfb += 4
            ingenieriaagronomia += 4
        End If
        'FIN PREGUNTA 6'
        'INICIO PREGUNTA 7'
        If RadioButton25.Checked Then
            licenciaturaendiseñodemodas += 1
            medicociruganopartero += 1
            ingenieriaindustrial += 1
            licenciaturaenderecho += 1
            licenciaturaenarquitectura += 1
            licenciaturaenenfermeria += 1
            licenciaturaenadministracion += 1
            licenciaturaendisenodeinteriores += 1
            ingenieriacivil += 1
            licenciaturaenmercadotecnia += 1
            ingenieriaeninformatica += 1
            ingenieriaenrobotica += 1
            licenciaturaencontaduriapublica += 1
            licenciaturaenrecursoshumanos += 1
            licenciaturaentrabajosocial += 1
            licenciaturaencriminologia += 1
            ingenieriaenlogisticasytransportes += 1
            licenciaturaenartesplasticas += 1
            ingenieriaencomputacion += 1
            licenciaturaenhistoria += 1
            docentedeprimaria += 1
            docentepreescolar += 1
            periodismo += 1
            piloto += 1
            militar += 1
            licenciaturaenmedicodentista += 1
            licenciaturaennegociosinternacionales += 1
            ingenieriaquimica += 1
            licenciaturaenpscologia += 1
            tecnivosuperioruniversitarioenterapiafisica += 1
            licenciaturaencienciasforenses += 1
            licenciaturaengastronomia += 1
            licenciaturaenculturafisicaydeporte += 1
            licenciaturaennutricion += 1
            licenciaturaengeografia += 1
        End If
        If RadioButton27.Checked Then
            ingenieriaagronomia += 2
        End If
        If RadioButton28.Checked Then
            licenciaturaquimica += 3
            licenciaturaenbiologia += 3
            licenciaturaenqfb += 3
        End If
        If RadioButton26.Checked Then
            medicaveterinario += 4
        End If
        'FIN PREGUNTA 7'
        'INICIO PREGUNTA 8'
        If RadioButton29.Checked Then
            licenciaturaenbiologia += 1
            licenciaturaengeografia += 1
            licenciaturaenqfb += 1
            ingenieriaagronomia += 1
            medicociruganopartero += 1
            ingenieriaindustrial += 1
            licenciaturaenderecho += 1
            licenciaturaenenfermeria += 1
            licenciaturaenadministracion += 1
            ingenieriacivil += 1
            licenciaturaenmercadotecnia += 1
            ingenieriaeninformatica += 1
            ingenieriaenrobotica += 1
            licenciaturaencontaduriapublica += 1
            licenciaturaenrecursoshumanos += 1
            licenciaturaentrabajosocial += 1
            licenciaturaencriminologia += 1
            ingenieriaenlogisticasytransportes += 1
            ingenieriaencomputacion += 1
            licenciaturaenhistoria += 1
            docentedeprimaria += 1
            docentepreescolar += 1
            periodismo += 1
            piloto += 1
            militar += 1
            licenciaturaenmedicodentista += 1
            licenciaturaquimica += 1
            medicaveterinario += 1
            licenciaturaenculturafisicaydeporte += 1
            licenciaturaennutricion += 1
            licenciaturaennegociosinternacionales += 1
            ingenieriaquimica += 1
            licenciaturaenpscologia += 1
            tecnivosuperioruniversitarioenterapiafisica += 1
            licenciaturaencienciasforenses += 1
            licenciaturaengastronomia += 1
        End If
        If RadioButton31.Checked Then
            licenciaturaenarquitectura += 2
        End If
        If RadioButton32.Checked Then
            licenciaturaenpscologia += 3
        End If
        If RadioButton30.Checked Then
            licenciaturaendiseñodemodas += 4
            licenciaturaendisenodeinteriores += 4
            licenciaturaenartesplasticas += 4
        End If
        'FIN PREGUNTA 8'
        'INICIO PREGUNTA 9'
        If RadioButton33.Checked Then
            licenciaturaenderecho += 1
            ingenieriaindustrial += 1
            licenciaturaenadministracion += 1
            licenciaturaendisenoindustrial += 1
            ingenieriacivil += 1
            ingenieriaeninformatica += 1
            licenciaturaencontaduriapublica += 1
            licenciaturaenrecursoshumanos += 1
            licenciaturaencriminologia += 1
            ingenieriaenlogisticasytransportes += 1
            ingenieriaencomputacion += 1
            licenciaturaenhistoria += 1
            periodismo += 1
            piloto += 1
            militar += 1
            ingenieriaquimica += 1
            licenciaturaencienciasforenses += 1
            licenciaturaengastronomia += 1
            licenciaturaquimica += 1
            medicaveterinario += 1
            licenciaturaengeografia += 1
            licenciaturaenqfb += 1
            ingenieriaagronomia += 1
            licenciaturaendisenodeinteriores += 1
        End If
        If RadioButton35.Checked Then
            licenciaturaenmercadotecnia += 2
            ingenieriaenrobotica += 2
            licenciaturaentrabajosocial += 2
            licenciaturaenbiologia += 2
        End If
        If RadioButton36.Checked Then
            medicociruganopartero += 3
            tecnivosuperioruniversitarioenterapiafisica += 3
            licenciaturaenenfermeria += 3
            licenciaturaenmedicodentista += 3
            licenciaturaenpscologia += 3
        End If
        If RadioButton34.Checked Then
            docentedeprimaria += 4
            docentepreescolar += 4
            licenciaturaenculturafisicaydeporte += 4
            licenciaturaennutricion += 4
        End If
        'FIN PREGUNTA 9'
        'INICIO PREGUNTA 10'
        If RadioButton37.Checked Then
            medicaveterinario += 1
            licenciaturaenenfermeria += 1
            licenciaturaenpscologia += 1
            tecnivosuperioruniversitarioenterapiafisica += 1
            licenciaturaenculturafisicaydeporte += 1
            licenciaturaendisenodeinteriores += 1
            licenciaturaenartesplasticas += 1
            licenciaturaennutricion += 1
            licenciaturaengeografia += 1
            licenciaturaenhistoria += 1
            licenciaturaenqfb += 1
            militar += 1
            licenciaturaenmedicodentista += 1
            licenciaturaengastronomia += 1
            licenciaturaendiseñodemodas += 1
            ingenieriaagronomia += 1
        End If
        If RadioButton39.Checked Then
            medicociruganopartero += 2
            ingenieriaeninformatica += 2
            ingenieriaenrobotica += 2
            licenciaturaencontaduriapublica += 2
            licenciaturaencienciasforenses += 2
            ingenieriaencomputacion += 2
            licenciaturaenbiologia += 2
            docentedeprimaria += 2
            docentepreescolar += 2
            piloto += 2
        End If
        If RadioButton40.Checked Then
            ingenieriaindustrial += 3
            licenciaturaenarquitectura += 3
            ingenieriaquimica += 3
            licenciaturaendisenoindustrial += 3
            ingenieriacivil += 3
            licenciaturaencriminologia += 3
            ingenieriaenlogisticasytransportes += 3
            licenciaturaquimica += 3
        End If
        If RadioButton38.Checked Then
            licenciaturaennegociosinternacionales += 4
            licenciaturaenrecursoshumanos += 4
            licenciaturaenderecho += 4
            licenciaturaenadministracion += 4
            licenciaturaenmercadotecnia += 4
            licenciaturaentrabajosocial += 4
            periodismo += 4
        End If
        'FIN PREGUNTA 10'
        'INICIO PREGUNTA 11'
        If RadioButton41.Checked Then
            medicaveterinario += 1
            licenciaturaenenfermeria += 1
            licenciaturaenpscologia += 1
            tecnivosuperioruniversitarioenterapiafisica += 1
            licenciaturaenculturafisicaydeporte += 1
            licenciaturaendisenodeinteriores += 1
            licenciaturaenartesplasticas += 1
            licenciaturaennutricion += 1
            licenciaturaengeografia += 1
            licenciaturaenhistoria += 1
            licenciaturaenqfb += 1
            militar += 1
            licenciaturaenmedicodentista += 1
            licenciaturaengastronomia += 1
            licenciaturaendiseñodemodas += 1
            ingenieriaagronomia += 1
            medicociruganopartero += 1
            licenciaturaencienciasforenses += 1
            licenciaturaenbiologia += 1
            docentepreescolar += 1
            licenciaturaenarquitectura += 1
            ingenieriacivil += 1
            licenciaturaencriminologia += 1
            licenciaturaquimica += 1
            licenciaturaennegociosinternacionales += 1
            licenciaturaenrecursoshumanos += 1
            licenciaturaenderecho += 1
            licenciaturaenadministracion += 1
            licenciaturaenmercadotecnia += 1
            licenciaturaentrabajosocial += 1
        End If
        If RadioButton43.Checked Then
            licenciaturaencontaduriapublica += 2
            docentedeprimaria += 2
            ingenieriaquimica += 2
            licenciaturaendisenoindustrial += 2
            periodismo += 4
            ingenieriaenlogisticasytransportes += 2
        End If
        If RadioButton44.Checked Then
            piloto += 3
            ingenieriaindustrial += 3
        End If
        If RadioButton42.Checked Then
            ingenieriaeninformatica += 4
            ingenieriaenrobotica += 4
            ingenieriaencomputacion += 4
        End If
        'FIN PREGUNTA 11'
        'INICIO PREGUNTA 12'
        If RadioButton45.Checked Then
            ingenieriaindustrial += 1
            licenciaturaennegociosinternacionales += 1
            ingenieriaquimica += 1
            licenciaturaenadministracion += 1
            licenciaturaendisenoindustrial += 1
            ingenieriacivil += 1
            licenciaturaenmercadotecnia += 1
            ingenieriaeninformatica += 1
            ingenieriaenrobotica += 1
            licenciaturaencontaduriapublica += 1
            licenciaturaenrecursoshumanos += 1
            licenciaturaentrabajosocial += 1
            licenciaturaencriminologia += 1
            licenciaturaencienciasforenses += 1
            ingenieriaenlogisticasytransportes += 1
            ingenieriaencomputacion += 1
            docentedeprimaria += 1
            docentepreescolar += 1
            piloto += 1
            militar += 1
            ingenieriaagronomia += 1
            licenciaturaengastronomia += 1
            medicaveterinario += 1
            licenciaturaenenfermeria += 1
            licenciaturaenpscologia += 1
            licenciaturaenqfb += 1
            licenciaturaenbiologia += 1
            licenciaturaquimica += 1
            periodismo += 1
            licenciaturaenmedicodentista += 1
            medicociruganopartero += 1
            tecnivosuperioruniversitarioenterapiafisica += 1
            licenciaturaenculturafisicaydeporte += 1
            licenciaturaennutricion += 1
        End If
        If RadioButton47.Checked Then
            licenciaturaenderecho += 2
            licenciaturaendisenodeinteriores += 2
            licenciaturaenarquitectura += 2
        End If
        If RadioButton48.Checked Then
            licenciaturaenhistoria += 3
            licenciaturaengeografia += 3
            licenciaturaendiseñodemodas += 3
        End If
        If RadioButton46.Checked Then
            licenciaturaenartesplasticas += 4
        End If
        'FIN PREGUNTA 12'
        'INICIO PREGUNTA 13'
        If RadioButton49.Checked Then
            ingenieriaquimica += 1
            licenciaturaennegociosinternacionales += 1
            licenciaturaenderecho += 1
            licenciaturaenadministracion += 1
            ingenieriaeninformatica += 1
            ingenieriaenrobotica += 1
            licenciaturaencontaduriapublica += 1
            licenciaturaenrecursoshumanos += 1
            licenciaturaentrabajosocial += 1
            licenciaturaencriminologia += 1
            licenciaturaencienciasforenses += 1
            ingenieriaenlogisticasytransportes += 1
            ingenieriaencomputacion += 1
            docentedeprimaria += 1
            docentepreescolar += 1
            militar += 1
            ingenieriaagronomia += 1
            licenciaturaengastronomia += 1
            licenciaturaendiseñodemodas += 1
            medicaveterinario += 1
            licenciaturaenenfermeria += 1
            licenciaturaenpscologia += 1
            licenciaturaenqfb += 1
            licenciaturaenbiologia += 1
            licenciaturaquimica += 1
            periodismo += 1
            licenciaturaenmedicodentista += 1
            medicociruganopartero += 1
            tecnivosuperioruniversitarioenterapiafisica += 1
            licenciaturaenculturafisicaydeporte += 1
            licenciaturaennutricion += 1
        End If
        If RadioButton51.Checked Then
            licenciaturaenmercadotecnia += 2
            licenciaturaendisenodeinteriores += 2
            licenciaturaenartesplasticas += 2
            licenciaturaengeografia += 2
            licenciaturaenhistoria += 2
        End If
        If RadioButton52.Checked Then
            ingenieriaindustrial += 3
            licenciaturaendisenoindustrial += 3
        End If
        If RadioButton50.Checked Then
            licenciaturaenarquitectura += 4
            ingenieriacivil += 4
        End If
        'INICIO PREGUNTA 14'
        If RadioButton53.Checked Then
            licenciaturaenartesplasticas += 1
            licenciaturaengeografia += 1
            licenciaturaenhistoria += 1
            ingenieriaagronomia += 1
            licenciaturaengastronomia += 1
            licenciaturaendiseñodemodas += 1
            ingenieriaeninformatica += 1
            ingenieriaenrobotica += 1
            licenciaturaencontaduriapublica += 1
            ingenieriaencomputacion += 1
            docentedeprimaria += 1
            docentepreescolar += 1
            piloto += 1
            ingenieriaindustrial += 1
            licenciaturaenarquitectura += 1
            ingenieriaquimica += 1
            licenciaturaendisenodeinteriores += 1
            ingenieriacivil += 1
            ingenieriaenlogisticasytransportes += 1
            licenciaturaennegociosinternacionales += 1
            licenciaturaenrecursoshumanos += 1
            licenciaturaenderecho += 1
            licenciaturaenmercadotecnia += 1
        End If
        If RadioButton55.Checked Then
            militar += 2
            licenciaturaquimica += 2
            licenciaturaenadministracion += 2
            periodismo += 2
        End If
        If RadioButton56.Checked Then
            licenciaturaenculturafisicaydeporte += 3
            licenciaturaenqfb += 3
            licenciaturaencriminologia += 3
            licenciaturaenbiologia += 3
        End If
        If RadioButton54.Checked Then
            medicaveterinario += 4
            medicociruganopartero += 4
            licenciaturaenenfermeria += 4
            licenciaturaenpscologia += 4
            tecnivosuperioruniversitarioenterapiafisica += 4
            licenciaturaennutricion += 4
            licenciaturaenmedicodentista += 4
            licenciaturaencienciasforenses += 4
            licenciaturaentrabajosocial += 4
        End If
        'FIN PREGUNTA 14'
        'INICIO PREGUNTA 15'
        If RadioButton57.Checked Then
            licenciaturaenartesplasticas += 1
            licenciaturaengeografia += 1
            licenciaturaenhistoria += 1
            ingenieriaagronomia += 1
            licenciaturaengastronomia += 1
            licenciaturaendiseñodemodas += 1
            ingenieriaeninformatica += 1
            ingenieriaenrobotica += 1
            licenciaturaencontaduriapublica += 1
            ingenieriaencomputacion += 1
            docentedeprimaria += 1
            docentepreescolar += 1
            piloto += 1
            ingenieriaindustrial += 1
            licenciaturaenarquitectura += 1
            ingenieriaquimica += 1
            licenciaturaendisenodeinteriores += 1
            ingenieriacivil += 1
            ingenieriaenlogisticasytransportes += 1
            licenciaturaennegociosinternacionales += 1
            licenciaturaenrecursoshumanos += 1
            licenciaturaenderecho += 1
            licenciaturaenmercadotecnia += 1
            militar += 1
            periodismo += 1
            licenciaturaenadministracion += 1
            licenciaturaentrabajosocial += 1
        End If
        If RadioButton59.Checked Then
            licenciaturaencriminologia += 2
            medicaveterinario += 2
            licenciaturaenpscologia += 2
        End If
        If RadioButton60.Checked Then
            licenciaturaquimica += 3
            licenciaturaenmedicodentista += 3
        End If
        If RadioButton58.Checked Then
            licenciaturaenculturafisicaydeporte += 4
            licenciaturaenqfb += 4
            licenciaturaenbiologia += 4
            medicociruganopartero += 4
            licenciaturaenenfermeria += 4
            tecnivosuperioruniversitarioenterapiafisica += 4
            licenciaturaennutricion += 4
            licenciaturaencienciasforenses += 4
        End If
        'FIN PREGUNTA 15'
        'INICIO PREGUNTA 16'
        If RadioButton61.Checked Then
            licenciaturaengeografia += 1
            licenciaturaenhistoria += 1
            ingenieriaenrobotica += 1
            docentedeprimaria += 1
            docentepreescolar += 1
            piloto += 1
            licenciaturaenarquitectura += 1
            ingenieriaquimica += 1
            ingenieriacivil += 1
            militar += 1
            licenciaturaquimica += 1
            licenciaturaenculturafisicaydeporte += 1
            licenciaturaenqfb += 1
            licenciaturaencriminologia += 1
            licenciaturaenbiologia += 1
            licenciaturaenenfermeria += 1
            licenciaturaencienciasforenses += 1
            licenciaturaentrabajosocial += 1
            licenciaturaenderecho += 1
        End If
        If RadioButton63.Checked Then
            ingenieriaeninformatica += 2
            ingenieriaencomputacion += 2
            ingenieriaindustrial += 2
            ingenieriaenlogisticasytransportes += 2
        End If
        If RadioButton64.Checked Then
            licenciaturaendisenodeinteriores += 3
            licenciaturaenartesplasticas += 3
            licenciaturaennegociosinternacionales += 3
            licenciaturaenrecursoshumanos += 3
            periodismo += 3
            medicociruganopartero += 3
        End If
        If RadioButton62.Checked Then
            ingenieriaagronomia += 4
            licenciaturaengastronomia += 4
            licenciaturaendiseñodemodas += 4
            licenciaturaenmercadotecnia += 4
            licenciaturaencontaduriapublica += 4
            licenciaturaenadministracion += 4
            medicaveterinario += 4
            licenciaturaenpscologia += 4
            tecnivosuperioruniversitarioenterapiafisica += 4
            licenciaturaennutricion += 4
            licenciaturaenmercadotecnia += 4
        End If
        'FIN PREGUNTA 16'
        'INICIO PREGUNTA 17'
        If RadioButton65.Checked Then
            medicaveterinario += 1
            licenciaturaenenfermeria += 1
            licenciaturaenqfb += 1
            militar += 1
            licenciaturaenmedicodentista += 1
            medicociruganopartero += 1
            ingenieriaindustrial += 1
            ingenieriaeninformatica += 1
            licenciaturaencontaduriapublica += 1
            licenciaturaencienciasforenses += 1
            piloto += 1
            licenciaturaenarquitectura += 1
            ingenieriaquimica += 1
            licenciaturaencriminologia += 1
            licenciaturaquimica += 1
            licenciaturaenrecursoshumanos += 1
            licenciaturaenadministracion += 1
            licenciaturaentrabajosocial += 1
            periodismo += 1
        End If
        If RadioButton67.Checked Then
            licenciaturaenpscologia += 2
            tecnivosuperioruniversitarioenterapiafisica += 2
            ingenieriaagronomia += 2
            licenciaturaengastronomia += 2
            licenciaturaendiseñodemodas += 2
            licenciaturaenbiologia += 2
            licenciaturaendisenoindustrial += 2
            ingenieriaenlogisticasytransportes += 2
            licenciaturaenderecho += 2
            licenciaturaenmercadotecnia += 2
        End If
        If RadioButton68.Checked Then
            licenciaturaendisenodeinteriores += 3
            ingenieriaenrobotica += 3
            ingenieriaencomputacion += 3
            ingenieriacivil += 3
        End If
        If RadioButton66.Checked Then
            licenciaturaenculturafisicaydeporte += 4
            licenciaturaenartesplasticas += 4
            licenciaturaennutricion += 4
            licenciaturaengeografia += 4
            licenciaturaenhistoria += 4
            docentedeprimaria += 4
            docentepreescolar += 4
        End If
        'FIN PREGUNTA 17 '
        'INICIO PREGUNTA 18'
        If RadioButton69.Checked Then
            medicaveterinario += 1
            licenciaturaenenfermeria += 1
            licenciaturaenqfb += 1
            militar += 1
            licenciaturaenmedicodentista += 1
            medicociruganopartero += 1
            ingenieriaindustrial += 1
            ingenieriaeninformatica += 1
            licenciaturaencontaduriapublica += 1
            licenciaturaencienciasforenses += 1
            piloto += 1
            licenciaturaenarquitectura += 1
            ingenieriaquimica += 1
            licenciaturaencriminologia += 1
            licenciaturaquimica += 1
            licenciaturaenrecursoshumanos += 1
            licenciaturaenadministracion += 1
            licenciaturaentrabajosocial += 1
            licenciaturaenpscologia += 1
            tecnivosuperioruniversitarioenterapiafisica += 1
            ingenieriaagronomia += 1
            licenciaturaendiseñodemodas += 1
            licenciaturaenbiologia += 1
            licenciaturaendisenoindustrial += 1
            ingenieriaenlogisticasytransportes += 1
            licenciaturaenderecho += 1
            licenciaturaenmercadotecnia += 1
            ingenieriaenrobotica += 1
            ingenieriaencomputacion += 1
            ingenieriacivil += 1
            licenciaturaennutricion += 1
        End If
        If RadioButton71.Checked Then
            licenciaturaengastronomia += 2
            licenciaturaendisenodeinteriores += 2
            licenciaturaenculturafisicaydeporte += 2
            licenciaturaenhistoria += 2
        End If
        If RadioButton72.Checked Then
            docentepreescolar += 3
            docentedeprimaria += 3
            licenciaturaengeografia += 3
        End If
        If RadioButton70.Checked Then
            licenciaturaenartesplasticas += 4
            periodismo += 4
        End If
        'FIN PREGUNTA 18'
        'INICIO PREGUNTA 19'
        If RadioButton73.Checked Then
            licenciaturaenhistoria += 1
            docentedeprimaria += 1
            docentepreescolar += 1
            licenciaturaquimica += 1
            licenciaturaenqfb += 1
            licenciaturaenbiologia += 1
            licenciaturaenenfermeria += 1
            licenciaturaentrabajosocial += 1
            medicociruganopartero += 1
            licenciaturaenmercadotecnia += 1
            medicaveterinario += 1
            licenciaturaenpscologia += 1
            licenciaturaennutricion += 1
            licenciaturaenmedicodentista += 1
            licenciaturaencriminologia += 1
        End If
        If RadioButton75.Checked Then
            ingenieriaenrobotica += 2
            licenciaturaenarquitectura += 2
            ingenieriacivil += 2
            militar += 2
            ingenieriaeninformatica += 2
            ingenieriaencomputacion += 2
            ingenieriaindustrial += 2
            ingenieriaagronomia += 2
            licenciaturaencontaduriapublica += 2
            licenciaturaencienciasforenses += 2
            tecnivosuperioruniversitarioenterapiafisica += 2
        End If
        If RadioButton72.Checked Then
            licenciaturaengeografia += 3
            ingenieriacivil += 3
            licenciaturaenculturafisicaydeporte += 3
            ingenieriaenlogisticasytransportes += 3
            licenciaturaendisenodeinteriores += 3
            licenciaturaenrecursoshumanos += 3
            licenciaturaengastronomia += 3
            licenciaturaenadministracion += 3
            licenciaturaenderecho += 3
        End If
        If RadioButton74.Checked Then
            licenciaturaendiseñodemodas += 4
            piloto += 4
            licenciaturaenartesplasticas += 4
            licenciaturaennegociosinternacionales += 4
            periodismo += 4
        End If
        'FIN PREGUNTA 19'
        'INICIO PREGUNTA 20'
        If RadioButton77.Checked Then
            licenciaturaenhistoria += 1
            licenciaturaentrabajosocial += 1
            licenciaturaenmedicodentista += 1
            licenciaturaenmercadotecnia += 1
            licenciaturaencriminologia += 1
            licenciaturaencienciasforenses += 1
            licenciaturaenarquitectura += 1
            militar += 1
            tecnivosuperioruniversitarioenterapiafisica += 1
            ingenieriaeninformatica += 1
            ingenieriaencomputacion += 1
            licenciaturaencontaduriapublica += 1
            licenciaturaengeografia += 1
            ingenieriacivil += 1
            ingenieriaenlogisticasytransportes += 1
            licenciaturaendisenodeinteriores += 1
            licenciaturaendisenoindustrial += 1
            licenciaturaendiseñodemodas += 1
            licenciaturaenrecursoshumanos += 1
            licenciaturaenculturafisicaydeporte += 1
            licenciaturaenadministracion += 1
            periodismo += 1
            licenciaturaenderecho += 1
            piloto += 1
            licenciaturaennegociosinternacionales += 1
        End If
        If RadioButton79.Checked Then
            licenciaturaenenfermeria += 2
            medicaveterinario += 2
            licenciaturaennutricion += 2
            ingenieriaenrobotica += 2
            licenciaturaengastronomia += 2
        End If
        If RadioButton80.Checked Then
            docentedeprimaria += 3
            docentepreescolar += 3
            medicociruganopartero += 3
            licenciaturaenpscologia += 1
            ingenieriaagronomia += 3
        End If
        If RadioButton78.Checked Then
            licenciaturaquimica += 4
            licenciaturaenqfb += 4
            licenciaturaenbiologia += 4
            ingenieriaquimica += 4
            ingenieriaindustrial += 4
            licenciaturaenartesplasticas += 4
        End If
        'FIN PREGUNTA 20'
        valores(0) = medicociruganopartero
        valores(1) = ingenieriaindustrial
        valores(2) = licenciaturaennegociosinternacionales
        valores(3) = medicaveterinario
        valores(4) = licenciaturaenderecho
        valores(5) = licenciaturaenarquitectura
        valores(6) = licenciaturaenenfermeria
        valores(7) = ingenieriaquimica
        valores(8) = licenciaturaenadministracion
        valores(9) = licenciaturaendisenoindustrial
        valores(10) = ingenieriacivil
        valores(11) = licenciaturaenmercadotecnia
        valores(12) = ingenieriaeninformatica
        valores(13) = ingenieriaenrobotica
        valores(14) = licenciaturaencontaduriapublica
        valores(15) = licenciaturaenrecursoshumanos
        valores(16) = licenciaturaenpscologia
        valores(17) = licenciaturaentrabajosocial
        valores(18) = tecnivosuperioruniversitarioenterapiafisica
        valores(19) = licenciaturaenculturafisicaydeporte
        valores(20) = licenciaturaencriminologia
        valores(21) = licenciaturaencienciasforenses
        valores(22) = ingenieriaenlogisticasytransportes
        valores(23) = licenciaturaendisenodeinteriores
        valores(24) = licenciaturaenartesplasticas
        valores(25) = licenciaturaennutricion
        valores(26) = ingenieriaencomputacion
        valores(27) = licenciaturaengeografia
        valores(28) = licenciaturaenhistoria
        valores(29) = licenciaturaenqfb
        valores(30) = licenciaturaenbiologia
        valores(31) = licenciaturaquimica
        valores(32) = docentedeprimaria
        valores(33) = docentepreescolar
        valores(34) = periodismo
        valores(35) = piloto
        valores(36) = militar
        valores(37) = licenciaturaenmedicodentista
        valores(38) = ingenieriaagronomia
        valores(39) = licenciaturaengastronomia
        valores(40) = licenciaturaendiseñodemodas


        Test2.Show()
        Me.Hide()


    End Sub

    Private Sub RadioButton163_CheckedChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class