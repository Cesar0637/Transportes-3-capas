using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Transportes_3_capas.CalculadoraService;

namespace Transportes_3_capas.Catalogos.Calculadora
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        calculadora_ServiceSoapClient cliente_WS;
        protected void Page_Load(object sender, EventArgs e)
        {
            cliente_WS = new calculadora_ServiceSoapClient();
        }

        protected void btnSumar_Click(object sender, EventArgs e)
        {
            double a=double.Parse(txta.Text);
            double b=double.Parse(txtb.Text);

            double resultado = cliente_WS.Suma(a, b);
            lblresultado.Text = resultado.ToString();
        }

        protected void btnRestar_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txta.Text);
            double b = double.Parse(txtb.Text);

            double resultado = cliente_WS.Resta(a, b);
            lblresultado.Text = resultado.ToString();
        }

        protected void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txta.Text);
            double b = double.Parse(txtb.Text);

            double resultado = cliente_WS.multiplicacion(a, b);
            lblresultado.Text = resultado.ToString();
        }

        protected void btnDividir_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txta.Text);
            double b = double.Parse(txtb.Text);

            double resultado = cliente_WS.division(a, b);
            lblresultado.Text = resultado.ToString();
        }
    }
}