using Xunit;
using Imperium.Models;

public class ChamadoTests
{
    [Fact]
    public void DeveCriarChamadoValido()
    {
        // Arrange
        var chamado = new Chamado
        {
            Titulo = "Erro no sistema",
            DataChamado = "2025-05-10",
            SetorChamado = "TI",
            TipoProblema = "Software",
            Urgencia = "Alta",
            Descricao = "Sistema travando ao logar",
            IdFuncionario = 1,
            Status = "em aberto"
        };

        // Act & Assert
        Assert.NotNull(chamado);
        Assert.Equal("Erro no sistema", chamado.Titulo);
        Assert.Equal("Alta", chamado.Urgencia);
        Assert.Equal("em aberto", chamado.Status);
    }
}
