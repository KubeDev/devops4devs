using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ReviewFilmes.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Filmes",
                columns: table => new
                {
                    FilmeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Titulo = table.Column<string>(type: "text", nullable: true),
                    Resumo = table.Column<string>(type: "text", nullable: true),
                    Lancamento = table.Column<string>(type: "text", nullable: true),
                    Categoria = table.Column<string>(type: "text", nullable: true),
                    Elenco = table.Column<string>(type: "text", nullable: true),
                    Direcao = table.Column<string>(type: "text", nullable: true),
                    Slide = table.Column<string>(type: "text", nullable: true),
                    Thumb = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmes", x => x.FilmeId);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: true),
                    Descricao = table.Column<string>(type: "text", nullable: true),
                    FilmeId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Reviews_Filmes_FilmeId",
                        column: x => x.FilmeId,
                        principalTable: "Filmes",
                        principalColumn: "FilmeId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_FilmeId",
                table: "Reviews",
                column: "FilmeId");


            migrationBuilder.InsertData(
table: "Filmes",
columns: new[] {
            "Titulo",
            "Resumo",
"Lancamento",
"Categoria",
"Elenco",
"Direcao",
"Slide",
"Thumb"
},
values: new object[,]
{
  {
	  "Bad Boys: Até O Fim",
	  "Os Bad Boys preferidos do mundo todo estão de volta com a mistura icônica de ação eletrizante e comédia escrachada mas, dessa vez, com uma virada: os melhores de Miami são agora os mais procurados.",
	  "Junho de 2024",
	  "Ação",
	  "Will Smith, Martin Lawrence",
	  "Adil El Arbi, Bilall Fallah",
	  "/images/badboys-slide.jpg",
	  "/images/badboys-thumb.jpg"
	},
    {
	  "Guerra Civil",
	  "Em um futuro não tão distante, quando uma guerra civil se instaura nos Estados Unidos, uma equipe pioneira de jornalistas de guerra viaja pelo país para registrar a dimensão e a situação de um cenário violento que tomou as ruas em uma rápida escalada, envolvendo toda a nação. No entanto, o trabalho de registro se transforma em uma guerra de sobrevivência quando eles também se tornam o alvo.",
	  "Abril de 2024",
	  "Ação, Ficção",
	  "Cailee Spaeny, Kirsten Dunst, Wagner Moura",
	  "Alex Garland",
	  "/images/guerra-civil-slide.jpg",
	  "/images/guerra-civil-thumb.jpg"
	},
    {
	  "Furiosa: Uma Saga Mad Max",
	  "Quando o mundo entra em colapso, a jovem Furiosa é sequestrada do Green Place das Muitas Mães e cai nas mãos de uma grande horda de motoqueiros liderada pelo Senhor da Guerra Dementus. Vagando pelo deserto condenado, eles encontram a cidadela controlada por Immortan Joe. Enquanto os dois tiranos lutam pelo poder e controle, Furiosa terá que sobreviver a muitos desafios para encontrar o caminho de volta para casa.",
	  "Maio de 2024",
      "Ação, Aventura",
	  "Chris Hemsworth, Quaden Bayles, Anya Taylor-Joy",
	  "George Miller",
	  "/images/furiosa-slide.jpg",
	  "/images/furiosa-thumb.jpg"
	},
    {
      "Cobra Kai",
	  "Anos depois de perder o grande torneio de caratê, Johnny Lawrence busca dar um novo significado para sua vida e abre o dojô Cobra Kai. Com isso, ele acaba reacendendo sua antiga rivalidade com Daniel LaRusso.",
	  "Maio de 2018",
	  "Comédia, Drama, Ação",
	  "Ralph Macchio, William Zabka",
	  "Jon Hurwitz, Josh Heald, Hayden Schlossberg",
	  "/images/cobra-kai-slide.jpg",
	  "/images/cobra-kai-thumb.jpg"
	},
    {
	  "Star Wars: O Acólito",
      "Baseada na famosa franquia de George Lucas, a série Star Wars: The Acolyte se situa cerca de 100 anos antes dos eventos do filme Episódio I - A Ameaça Fantasma. Durante os últimos dias da Alta República, onde os Jedi estão alcançando seu auge e liderando a República em explorações com iniciativas galácticas uma jovem ex-padawan se vê obrigada a se reunir com seu mestre Jedi para investigar uma série de crimes. No caminho, eles deparam-se com forças mais sinistras do que esperavam, entre segredos e potências emergentes do lado negro nos últimos dias da época da Alta República, os Jedi são ameaçados por uma força determinada a aniquilá-los.",
      "Junho de 2024",
	  "Ação, Fantasia. Ficção Científica",
	  "Amandla Stenberg, Carrie-Anne Moss,Dafne Keen",
	  "Leslye Headland, Rayne Roberts",
	  "/images/star-wars-slide.jpg",
	  "/images/star-wars-thumb.jpg"
	},
    {
	  "Planeta dos Macacos: O Reinado",
	  "Muitas sociedades de macacos cresceram desde quando César levou seu povo a um oásis, enquanto os humanos foram reduzidos a sobreviver e se esconder nas sombras.",
	  "Maio de 2024",
	  "Ação, Ficção científica",
	  "Freya Allan, Kevin Durand\r\n",
	  "Wes Ball",
	  "/images/planeta-macacos-slide.jpg",
	  "/images/planeta-macacos-thumb.jpg"
	},
    {
	  "Godzilla e Kong: O Novo Império",
	  "Godzilla e o todo-poderoso Kong enfrentam uma ameaça colossal escondida nas profundezas do planeta, desafiando a sua própria existência e a sobrevivência da raça humana.",
      "Março de 2024",
	  "Ação, Ficção científica",
	  "Rebecca Hall, Brian Tyree Henry, Dan Stevens",
	  "Adam Wingard",
	  "/images/godzilla-kong-slide.jpg",
	  "/images/godzilla-kong-thumb.jpg"
	},
		{
	  "Ghostbusters: Apocalipse de Gelo",
	  "Nesta sequência da franquia Ghostbusters, a família Spengler retorna para onde tudo começou: a famosa estação de bombeiros em Nova York. Eles pretendem se unir com os caça-fantasmas originais que desenvolveram um laboratório ultra secreto de pesquisa para levar a caça aos fantasmas a outro nível, mas quando a descoberta de um artefato antigo libera uma grande força do mal, os Ghostbusters das duas gerações precisam juntar as forças para proteger suas casas e salvar o mundo de uma segunda Era do Gelo.",
	  "Abril de 2024",
	  "Ação, Aventura, Fantasia",
	  "Paul Rudd, Carrie Coon, Finn Wolfhard",
	  "Gil Kenan",
	  "/images/caca-fantasmas-slide.jpg",
	  "/images/caca-fantasmas-thumb.jpg"
	}
});
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Filmes");
        }
    }
}
