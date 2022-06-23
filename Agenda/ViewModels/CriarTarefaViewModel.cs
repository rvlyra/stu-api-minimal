using Flunt.Notifications;
using Flunt.Validations;


namespace Agenda.ViewModels
{
    public class CriarTarefaViewModel : Notifiable<Notification>
    {
        public string Titulo { get; set; }
        
        public Tarefa MapTo()
        {
            var contract = (new Contract<Notification>()        
            .Requires()
            .IsNotNull(Titulo, "Informe o título da tarefa.")
            .IsGreaterThan(Titulo, 5, "Informe o título da tarefa."));

            AddNotifications(contract);

            return new Tarefa(Guid.NewGuid(), Titulo, false);
        }
        
    }
}