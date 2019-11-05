using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3_GSB_BalemrogV2
{
    public static class ControlleurM3
    {
        private static BalemrogBDDEntities maCo;
        public static void init()
        {
            maCo = new BalemrogBDDEntities();
        }

        public static List<fichefrais> listeFicheFrais()
        {
            return maCo.fichefrais.ToList();
        }
    }
}
