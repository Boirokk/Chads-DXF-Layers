using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chads_DXF_Layers
{
    class ToolList
    {
        public List<Tool> tools = new List<Tool>();

        public void addTool(Tool newTool)
        {
            tools.Add(newTool);
        }

        public Tool searchTools(String toolCode)
        {
            foreach (Tool aTool in tools)
            {
                if (aTool.getToolCode().Equals(toolCode))
                {
                    return aTool;
                }
           
            }
            return null;
        }

    }
}
