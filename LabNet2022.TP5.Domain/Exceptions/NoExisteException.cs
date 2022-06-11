namespace LabNet2022.TP5.Domain.Exceptions
{
    public class NoExisteException : Exception
    {
        public override string Message => $"El registro que intenta modificar o eliminar no existe";
    }
}
