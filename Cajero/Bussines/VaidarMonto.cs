using Cajero.Models;

namespace Cajero.Bussines
{
    public class VaidarMonto
    {
        public Boolean Validar(Monto dato)
        {
            if ((dato.monto % 5 == 0) && (dato.monto > 0)){
                return true;
            } else {
                return false;
            }
        }
    }
}
