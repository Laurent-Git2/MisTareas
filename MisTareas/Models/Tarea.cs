namespace MisTareas.Models
{
    public class Tarea//1. Créer Tarea

    {//2. Ajouter les propriétés
        public int Id { get; set; }

        public required string  Prioridad { get; set; }

        public required string Titulo { get; set; }

        public string? Descripcion { get; set; }

        public DateTime FechaCreacion { get; set; }

        public DateTime? FechaLimite { get; set; }

        public required string? Estado { get; set; }

        public string? Enlace { get; set; }

        // Utilisateur propriétaire de la tâche
        public string? UserId { get; set; }
    }
}
