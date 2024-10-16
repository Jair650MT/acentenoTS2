namespace acentenoTS2.Views;

public partial class SistemaUisrael : ContentPage
{
	public SistemaUisrael()
	{
		InitializeComponent();
	}

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
		try
	{
		if (pkNombreEstudiante.SelectedIndex==-1 || String.IsNullOrEmpty(txtNotaE1.Text) || String.IsNullOrEmpty(txtNotaE2.Text) || String.IsNullOrEmpty(txtNotaS1.Text) || String.IsNullOrEmpty(txtNotaS2.Text))
		{
			DisplayAlert("Error", "Campos Incompletos","ok");
		}
		else
		{
            Double notaS1 = Convert.ToDouble(txtNotaS1.Text);
            Double notaS2 = Convert.ToDouble(txtNotaS2.Text);
            Double notaE1 = Convert.ToDouble(txtNotaE1.Text);
            Double notaE2 = Convert.ToDouble(txtNotaE2.Text);
				Double parcial1 = notaS1 * 0.3 + notaE1 * 0.2;
                Double parcial2 = notaS2 * 0.3 + notaE2 * 0.2;
				Double notaFinal = parcial1 + parcial2;
				String fecha = dFechas.Date.ToString();

                lblparcial1.Text = " " + parcial1;

				lblparcial2.Text = " " +  parcial2;

				lblNotafinal.Text = " " + notaFinal;

				if (notaFinal<=4.9)
				{
					DisplayAlert("Lo sentimos","Usted ha reprobado el dia : "+fecha,"ok");
				}
				else
				{
					if (notaFinal>=5&& notaFinal<=6.9)
					{
                        DisplayAlert("Lo sentimos", "Usted tiene que rendir un examen complementario", "ok");
					}
					else
					{
						DisplayAlert("Felicidades","Usted aprobó en la fecha : "+fecha,"ok");
					}
				}
		}
			
		
	}
	catch (Exception ex)
	{

		DisplayAlert("Alerta", "Error" + ex.Message, "ok");
	}
    }
}