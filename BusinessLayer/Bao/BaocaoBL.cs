using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
using DataLayer;
using System.Data.SqlClient;

namespace BusinessLayer.Bao
{
    class BaocaoBL
    {
        private BaocaoDTO baocao;
        private BaocaoDAL baocaoDAL;
        public void taobaocao()
        {
            baocaoDAL.taobaocao(baocao);
        }

    }
}
