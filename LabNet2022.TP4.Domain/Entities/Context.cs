namespace LabNet2022.TP4.Domain.Entities
{
    public class ContextLogic
    {
        protected readonly NorthWindContext _context;

        public ContextLogic()
        {
            _context = new NorthWindContext();
        }

    }
}
