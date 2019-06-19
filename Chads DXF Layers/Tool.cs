using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chads_DXF_Layers
{
    class Tool
    {
        private String toolCode;
        private String description;
        private object image;
        private double diameter;
        private double maxLength;
        private double effectiveLength;
        private int workSpeed;
        
        

        public Tool()
        {
            // Create instance of Object
            
        }

        public Tool(String toolCode, String description, double diameter, 
            double maxLength, double effectiveLength, int workSpeed, object image)
        {
            this.workSpeed = workSpeed;
            this.toolCode = toolCode;
            this.description = description;
            this.diameter = diameter;
            this.maxLength = maxLength;
            this.effectiveLength = effectiveLength;
            this.image = image;
        }

        public Tool createTool(String toolCode, String description, double diameter,
            double maxLength, double effectiveLength, int workSpeed, object image)
        {
            return new Tool(toolCode, description, diameter, maxLength, effectiveLength, workSpeed, image);
        }

        public String getToolCode()
        {
            return this.toolCode;
        }

        public int getWorkSpeed()
        {
            return this.workSpeed;
        }

        public object getImage()
        {
            return this.image;
        }

        public String getDescription()
        {
            return this.description;
        }

        public double getDiameter()
        {
            return this.diameter;
        }

        public double getMaxLength()
        {
            return this.maxLength;
        }

        public double getEffectiveLength()
        {
            return this.effectiveLength;
        }
    }
}
