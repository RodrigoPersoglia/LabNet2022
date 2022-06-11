namespace LabNet2022.TP5.Domain.Entities
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
