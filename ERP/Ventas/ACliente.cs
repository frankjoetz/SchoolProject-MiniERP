﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaDeNegocios;
using System.Text.RegularExpressions;

namespace ERP.Ventas
{
    public partial class ACliente : Form
    {
        LogicaDeNegocios.Ventas.metodosVentas mV = new LogicaDeNegocios.Ventas.metodosVentas();
        public ACliente()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (isValidEmail(txtEmail.Text))
            {
                string status = "'Activo'";
                string valores = "'" + txtNombre.Text + "','" + txtApe.Text + "','" + txtEmpresa.Text + "'," + Int32.Parse(mtxtTel.Text) + ",'" + txtDir.Text + "','" + txtEmail.Text + "'," + status;
                bool result = mV.altaTabla("Cliente(Nombre,Apellido,Empresa,Telefono,Direccion,email,StatusCliente)", valores);
                if (result)
                {
                    MessageBox.Show("Si se pudo!");
                    this.Dispose();
                }
            }
            else
                MessageBox.Show("Correo electránico invalido");
            
        }
////////////////Filtros de caracteres/////////////
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void mtxtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtApe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        /////////////////////////////////////////////////////////////
        public static bool isValidEmail(string email)
        {
            string comprobar = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, comprobar))
            {
                if (Regex.Replace(email, comprobar, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
