using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
/// <summary>
/// Archivo donde se definen las clases del Dominio del problema.
/// </summary>
namespace Lab.Models
{

    /// <summary>
    /// Clase que representa a una persona en el Sistema.
    /// </summary>
    /// <remarks>
    /// Esta clase pertenece al modelo del Dominio y posee las siguientes restricciones:
    /// - No permite valores null en sus atributos.
    /// </remarks>
    public class Persona
    {   
        public String Rut { get; set; }

        public string Nombre { get; set; }

        public string Paterno { get; set; }

        public string Materno { get; set; }   

        public List<Cotizacion> listCotizaciones {get; set;} 
    }



    public static Boolean validarRut(String rut)
    {
		    Regex expresion = new Regex("^([0-9]+-[0-9K])$");
		    
            string dv = rut[rut.lenght-1];
    		
            if (!expresion.IsMatch(rut))
            {
			    return false;
		    }

		    //string[] rutSinDv = rut.Split('-');
            int rutNum = int.Parse(rut.Split('-')[0])
            string dvCalculado = '';

            int sum = 0;
		    int factor = 1;
		    while (rut != 0) {
		    	factor++;
			    if (factor == 8)
			        factor = 2;
		        sum += (rutNum % 10)*factor;
			    rutNum = rutNum / 10;
		    }
		    sum = 11 - (sum % 11);
		    if (sum == 11)	{
			    svCalculado="0";
		    } elseif (sum==10) {
			    dvCalculado="K";
		    } else {
			    dvCalculado=sum.ToString;
		    }


    		if (dv != dvCalculado) {
			    return false;
		    }
		return true;
    }
}