using GreenfoxQuizApp.Entities;
using GreenfoxQuizApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenfoxQuizApp.Repositories
{
    public class GreenfoxQuizAppRepository
    {
        private GreenfoxQuizAppContext GreenfoxQuizAppContext;

        public GreenfoxQuizAppRepository(GreenfoxQuizAppContext greenfoxQuizAppContext)
        {
            GreenfoxQuizAppContext = greenfoxQuizAppContext;
        }

        public List<Text> GetList()
        {
            return GreenfoxQuizAppContext.Texts.ToList();
        }      

        public List<Text> GetRandomList()
        {
            return GreenfoxQuizAppContext.Texts.OrderBy(r => Guid.NewGuid()).Take(5).ToList();
        }
    }
}
