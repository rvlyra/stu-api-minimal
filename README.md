# API MINIMAL

<div style="display: inline_block">
  


  <img align="center" alt="Java" height="40" width="40" src="https://iconape.com/wp-content/files/rr/352323/svg/c-sharp-c-seeklogo.com.svg">
  <img align="center" alt="Typescript" height="30" width="40" src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/typescript/typescript-original.svg">
  <img align="center" alt=".NET" height="40" width="50" src="https://cdn.worldvectorlogo.com/logos/dotnet.svg">
  <img align="center" alt="Laravel" height="40" width="45" src="https://cdn.worldvectorlogo.com/logos/ef.svg">
  <img align="center" alt="Laravel" height="40" width="45" src="https://cdn.worldvectorlogo.com/logos/sqlite.svg">
  
</div>

<br />

Projeto estudos construído durante o treinamento de ASPNET Minimal APIs, curso produzido por Andre Baltieri @balta.io.

Inicializando o projeto:

    dotnet new web -o NameProject

Escolha a sua IDE. Se optar pelo VS Code, abra o Terminal e digite os seguintes comandos: 


*Para construir e corrigir a aplicação:*
    
    dotnet build

*Para iniciar a aplicação:*

    dotnet run

*__Ao Clonar a Aplicação__*

*Para restaurar e importar as dependências do projeto automaticamente:*
    
    dotnet restore


Verifique se o diretório Models está no projeto. Senão, basta criar utilizando o comando:

    md Models
    mkdir Models

Se preferir adiantar o processo, você pode copiar e colar no terminal, toda a cadeia a seguir:

    mkdir Models

        cd Models

            touch ClassName.cs

                cd ..
    
*Altere o nome da classe de acordo com o seu projeto.*


## Dependências do Projeto

Para utilizar um banco de dados dinâmico e otimizar os seus estudos:

    dotnet add package Microsoft.EntityFrameworkCore.SqLite

Para criar e utilizar Migrations, Updates e demais ações do dia a dia:

    dotnet add package Microsoft.EntityFrameworkCore.Design


Crie um diretório chamado Data, ou com o nome que desejar e insira uma classe com nomo *__AppDbContext.cs__* , que fará a representação do banco de dados no contexto da aplicação:

    mkdir Data
        cd Data
            cp AppDbContext.cs 

                echo "
                using System.Data.EntityFrameworkCore;
                namespace Tarefa.Data 
                { 
                    public class AppDdbContext : DbContext 
                        {
                    public SchoolContext() 
                    { 
                    }
                    public DbSet<Tarefa> Tarefas { get; set; } 
                    }
                }
                " >> AppDbContext.cs


Agora, basta inserir a connectionString:
        
    Public DbSet<Data> Datas { get; set; }
    ... 

    protected override void OnConfiguring(DbContextOptionBuilder options)
    => options.UseSqlite("DataSource=app.db;Cache=shared");

    