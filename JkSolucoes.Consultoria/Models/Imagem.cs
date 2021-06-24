using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JkSolucoes.Consultoria.Models
{
    public class Imagem
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Extension { get; set; }
        public int Length { get; set; }
        public byte[] Picture { get; set; }
        public IFormFile Img { get; set; }
        public string ContentType { get; set; }
    }
}
