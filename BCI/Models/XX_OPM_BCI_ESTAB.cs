﻿using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCI.Models
{

    public class XX_OPM_BCI_ESTAB
    {

        [ExplicitKey]
        public string Id { get; set; }
        public string Significado { get; set; }
        public string Descripcion { get; set; }
        public string RazonSocial { get; set; }
        public string RUC { get; set; }        
        public string ES_SOCIO { get; set; }
        public string Description => Significado + AdditionalData;
        public string AdditionalData {
            get { 
                if(Descripcion == null){
                    return  " - " + RUC;
                }else{
                    return " - " + RUC + " - " + Descripcion;
                }
            }
        }

        public override string ToString()
        {
            return Description;
        }

    }
        
}
