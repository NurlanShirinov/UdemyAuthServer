using System.Collections.Generic;

namespace SharedLibrary.Dtos
{
    public class ErrorDto
    {
        // set private edirik cunki bu propertiler sadece bu class icerisinden set edile bilsin. xaricden bashqa biri bu propertileri set etmek istese constructurlari set etsin.
        public List<string> Errors { get; private set; } // birden cox error gostermek ucun List sheklinde saxladiq. Sadece bir error gostermek isteyirikse sadece string tipinde saxlamali idik.
        public bool IsShow { get; private set; } //gelen errorun IsShow true olarsa bunu usere gostererik sadece developer ucun olan erroru false ederik.

        public ErrorDto()
        {
            Errors = new List<string>();
        }

        public ErrorDto(string error , bool isShow)
        {
            Errors.Add(error);
            isShow = true;
        }

        public ErrorDto(List<string> errors, bool isShow)
        {
            Errors = Errors;
            IsShow = isShow;
        }
    }
}