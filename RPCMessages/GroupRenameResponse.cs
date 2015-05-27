using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlackAPI.SlackModels;

namespace SlackAPI
{
    [RequestPath("groups.rename")]
    public class GroupRenameResponse : Response
    {
        public Channel channel; 
    }
}
