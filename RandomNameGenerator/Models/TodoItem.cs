using Microsoft.Azure.Mobile.Server;

namespace siscloudbookService.DataObjects
{
    public class TodoItem : EntityData
    {
        public string Text { get; set; }

        public bool Complete { get; set; }
    }
}