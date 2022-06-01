using System;

namespace LabNet2022.TP2
{
    public class Logic
    {
        public static void LanzarException()
        {
            throw new ArgumentException();
        }

        public static void LanzarCustomException()
        {
            throw new CustomException("Estoy lanzando mi excepción personalizada");
        }

    }
}
