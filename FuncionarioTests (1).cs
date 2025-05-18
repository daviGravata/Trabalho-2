using Xunit;
using Imperium.Models;

public class FuncionarioTests
{
    [Fact]
    public void DeveCriarFuncionarioValido()
    {
        // Arrange
        var funcionario = new Funcionario
        {
            Nome = "Neymar Junior",
            Setor = "Financeiro",
            EmailCorporativo = "neymar.junior@impoerium.com",
            SenhaHash = "hashSenha123",
            Perfil = "Gerente"
        };

        // Act & Assert
        Assert.NotNull(funcionario);
        Assert.Equal("Neymar Junior", funcionario.Nome);
        Assert.Equal("Financeiro", funcionario.Setor);
        Assert.Equal("neymar.junior@impoerium.com", funcionario.EmailCorporativo);
        Assert.Equal("Gerente", funcionario.Perfil);
    }
}
