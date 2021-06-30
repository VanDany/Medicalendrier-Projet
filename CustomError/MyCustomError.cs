using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomError
{
    public class MyCustomError : Exception
    {
        private string _Message;
        private int _Number;
        public MyCustomError(int number)
        {
            _Number = number;
            switch (_Number)
            {
                case 1:
                    _Message = "Une erreur critique est survenue lors de la création du nouveau patient.";
                    break;
                case 2:
                    _Message =
                        "Une erreur critique est survenue lors de l'annulation du rendez-vous.";
                    break;
                case 3:
                    _Message =
                        "Une erreur critique est survenue lors du déplacement du rendez-vous.";
                    break;
                case 4:
                    _Message =
                        "Une erreur critique est survenue lors de la récupération de la liste des spécialités.";
                    break;
                case 5:
                    _Message =
                        "Une erreur critique est survenue lors de la récupération de la liste des maisons médicales.";
                    break;
                case 6:
                    _Message =
                        "Une erreur critique est survenue lors de la récupération de la liste\n des association maisons médicales et des spécialités. Veuillez recommencer, le cas échéant contacter l'administrateur";
                    break;

                default:
                    _Message = "Erreur inconnue.";
                    break;
            }
        }
        public MyCustomError(Exception e)
        {
            if (e is SqlException)
            {
                SqlException sqlE = (SqlException) e;
                switch (sqlE.Number)
                {
                    case 547:
                        _Number = 1;
                        _Message = "la connection string manque.";
                        break;
                }
            }
            else
            {
                _Message = "not sql exception : " + e.Message;
                
            }
        }

        public void Show()
        {
            MessageBox.Show("Erreur " + _Number + " ---- " + _Message);
        }
        
        public int ErrorNumber
        {
            get { return _Number; }
        }

        public override string Message
        {
            get { return _Message; }
        }
    }
}

