using Blog_Dapper.Models;
using Blog_Dapper.Repositories;
using Blog_Dapper.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Dapper.Screens.OtherScreen
{
    public class LinkPostTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Link Post to Tag");
            Console.WriteLine("========================");
            Console.WriteLine("Choose a Post id: ");
            var postId = Choose.ChooseId();
            Console.WriteLine("Choose a Tag id: ");
            var tagId = Choose.ChooseId();

            Link(new PostTag
            {
                PostId = postId,
                TagId = tagId
            });

            Console.ReadKey();
            StartMenuScreen.Load();
        }

        private static void Link(PostTag postTag)
        {
            try
            {
                var repository = new Repository<PostTag>(Database.Connection);
                repository.Create(postTag);
                Console.WriteLine("Post linkado a Tag com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível linkar o post a tag!");
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}
