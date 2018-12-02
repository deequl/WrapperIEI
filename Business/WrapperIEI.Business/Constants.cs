using System;
using System.Collections.Generic;
using System.Text;

namespace WrapperIEI
{
    public static class Constants
    {
        // PROVIDERS

        public const string AMAZON = "Amazon";
        public const string EL_CORTE_INGLES = "El Corte Inglés";


        // PLACEHOLDERS
        public const string TITLE_PLACEHOLDER = "Titulo del libro";
        public const string AUTHOR_PLACEHOLDER = "Autor";

        //SYMBOLS
        public const string MONEY_SYMBOL = " €";
        public const string DISCOUNT_SYMBOL = " %";

        // MESSAGES
        public const string EMPTY_CONTENT_MESSAGE = "Por favor marque al menos un proveedor en el que buscar e indique un titulo o autor.";
        public const string EMPTY_TITLE_MESSAGE = "Uno o mas campos estan vacios";


    }
}
