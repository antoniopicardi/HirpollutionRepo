// This file was auto-generated by ML.NET Model Builder. 

using Microsoft.ML.Data;

namespace ML.Model
{
    public class ModelInput
    {
        [ColumnName("stazione"), LoadColumn(0)]
        public string Stazione { get; set; }


        [ColumnName("descrizione"), LoadColumn(1)]
        public string Descrizione { get; set; }


        [ColumnName("inquinante"), LoadColumn(2)]
        public string Inquinante { get; set; }


        [ColumnName("um"), LoadColumn(3)]
        public string Um { get; set; }


        [ColumnName("data_ora"), LoadColumn(4)]
        public string Data_ora { get; set; }


        [ColumnName("valore"), LoadColumn(5)]
        public float Valore { get; set; }


    }
}
