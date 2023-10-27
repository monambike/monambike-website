namespace Monambike.Web.Models
{
    public class Blog
    {
        public string Title { get; }

        public string Content { get; }

        public string Url { get; }

        public Blog(string title, string content)
        {
            Title = title;
            Content = content;
        }

        public static Blog FirstPost => new("Como comecei a usar ainda mais a tecnologia ao meu favor", content);

public static string content = """
Sempre gostei muito de tecnologia e sempre tentei utilizar ela ao meu favor. Aqui está como organizo minha vida através da tecnologia hoje em dia por meio de ferramentas comuns dispostas no mundo digital!

Google Contacts: Uma versão melhorada da agenda de contatos. Você pode acessar seus contatos em qualquer lugar do mundo de uma forma organizada com uma grande diversidade de informações.

Google Agenda: Anotar compromissos e eventos que posso ou não ir. Além de ser integrado com o Google Contacts, permitindo também evitar esquecer aniversários tendo em vista que o uso constante (Widgets no celular e acesso fácil no desktop com Web) não me deixaria esquecer.

Google Keep: Colocar notas com informações úteis para realizar depois. Perfeito tendo em vista que é fácil anexar links e imagens e organizar por categorias.

LinkedIn: Concentração de informações úteis do meu progresso profissional sem precisar ficar me preocupando com a disposição em vários lugares.

Facebook: Registro de informações de cunho pessoal.

Instagram: Facilidade na criação de contas e a disposição de imagens e conteúdos para fins de entretenimento muito mais acessíveis. Permitindo colocar imagens do meu portfólio de programação e pixel arte, vídeos que gostei e desenhos e fotos pessoais em diferentes contas de fácil e bonito acesso.

GitHub: Postagem e organização de códigos e projetos fechados e abertos, com lindas imagens e arquivos README.

Itch.Io: Hospedagem de jogos facilitando com que o jogador não tivesse dificuldade ao experimentar as minhas obras gratuitas.

OneDrive: Onde guardo todos os meus arquivos separadamente para que sempre que eu precise eu os tenha à mão. Fora que com o mesmo preço eu consigo 1TB de espaço e arquivos do Office, e ainda tenho a opção de aumentar a qualquer momento.

YouTube: Postar vídeos mais longos de gameplays com os meus amigos ou sozinho, de jogos que gostei de jogar ou de momentos legais.

OneNote: Espaço para realizar minhas anotações e estudos, permitindo que eu consiga organizar meu progresso de forma facilitada e caso precise utilizar novamente eu consiga. Uma evolução de arquivos Word para esse fim, que antigamente era um problema a demora e o trabalho de ter que ficar abrindo um por um para ver os conteúdos.

Pinterest: Mar de inspiração para os meus trabalhos, principalmente com imagens, animações, desenhos e fotos.

Notion: Informações dispostas em uma versão mais simples de um banco de dados. Guardo registros organizadamente onde ainda não posso guardar no meu banco de dados.
Coisas como alguns dos meus sonhos e objetivos alcançados, metas, jogos, desenhos, filmes que consumi.

Spotify: Organizar músicas por pastas, gêneros, cantores e sensações e poder ouvir facilmente em qualquer lugar.

Espero que esse post consiga te dar uma luz ou alguma inspiração em utilizar tecnologias do dia a dia para deixar seu dia a dia menos pesado e mais dinâmico de se trabalhar.
Compartilhe suas ideias e que ferramentas você usa para tornar o seu dia ainda melhor!

Seja inteligente, e gaste sua inteligência da melhor forma possível.
""";
    }
}
