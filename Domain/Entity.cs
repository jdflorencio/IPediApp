namespace IPediApp.Domain;


//essa classe nao pode ser instanciada somente herdada
public abstract class Entity
{
    public Entity()
    {
        //para gerar um novo ID em formato hash em tempo de execução
        Id = Guid.NewGuid();
    }

    public Guid Id { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedOn { get; set; }
    public string EditedBy { get; set; }
    public DateTime EditedOn { get; set; }

}
