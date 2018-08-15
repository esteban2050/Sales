﻿namespace Sales.Interfaces
{
    using System.Globalization;

    public interface Ilocalize
    {
        CultureInfo GetCurrentCultureInfo();

        void SetLocale(CultureInfo ci);
    }
}
