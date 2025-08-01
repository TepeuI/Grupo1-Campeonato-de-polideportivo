﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using PoliDeportivo.Views;
using PoliDeportivo.Views.Administracion;

namespace PoliDeportivo
{
    /// <summary>
    /// Lógica de interacción para MenuPrincipalAdmin.xaml
    /// </summary>
    public partial class MenuPrincipalAdmin : Window
    {
        public MenuPrincipalAdmin()
        {
            InitializeComponent();
        }


        private void btn_despliegueUsuario(object sender, RoutedEventArgs e)
        {
            MenuUsuario.Visibility = MenuUsuario.Visibility == Visibility.Visible
            ? Visibility.Collapsed
            : Visibility.Visible;

        }

        private void btn_despliegueAdmin(object sender, RoutedEventArgs e)
        {
            MenuAdmin.Visibility = MenuAdmin.Visibility == Visibility.Visible
            ? Visibility.Collapsed
            : Visibility.Visible;
        }

        private void btn_cerrarSesion(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();

        }


        private void btn_campeonatos(object sender, RoutedEventArgs e)
        {
            contenedor.Content = new CampeonatosUserControl();
        }

        private void btn_equipos(object sender, RoutedEventArgs e)
        {
            contenedor.Content = new EquiposUserControl();
        }

        private void btn_empleados(object sender, RoutedEventArgs e)
        {
            contenedor.Content = new EmpleadosUserControl();
        }

        private void btn_gestionUsr(object sender, RoutedEventArgs e)
        {
            contenedor.Content = new GestionUsrUserControl();
        }

        private void btn_puesto(object sender, RoutedEventArgs e)
        {
            contenedor.Content = new PuestosUserControl();
        }

        private void btn_entrenador(object sender, RoutedEventArgs e)
        {
            contenedor.Content = new EntrenadoresUserControl();
        }
        private void btn_cancha(object sender, RoutedEventArgs e)
        {
            contenedor.Content = new CanchaUserControl();
        }
       private void btn_estado_partido(object sender, RoutedEventArgs e)
        {
            contenedor.Content = new EstadoPartidoUserControl();
        }

        private void btn_contratacion(object sender, RoutedEventArgs e)
        {
            contenedor.Content = new ContratacionUserControl();
        }

        private void btn_tel_empleados(object sender, RoutedEventArgs e)
        {
            contenedor.Content = new TelefonoEmpUserControl();
        }
    }
}
