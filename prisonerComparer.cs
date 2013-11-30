using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace wiezien
{
    /*
     * Klasa komparatora dla obiektów typu prisoner
     */
    public class prisonerComparer : IComparer
    {
        /*
         * Funkcja porównująca dwóch więźniów na podstawie ich średniego wyniku
         */
        int IComparer.Compare(Object x, Object y)
        {
            Prisoner p1 = (Prisoner)x;
            Prisoner p2 = (Prisoner)y;

            if (p1.getMean() > p2.getMean())
                return 1;
            else if (p2.getMean() > p1.getMean())
                return -1;
            else
                return 0;
        }
    }
}
