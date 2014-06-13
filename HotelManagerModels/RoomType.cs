using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagerModels
{
    public class RoomType
    {

        public RoomType() { }
        public RoomType(int typeId, string typeName)
        {
            this.TypeId = typeId;
            this.TypeName = typeName;
        
        }
        public RoomType(int typeId, string typeName, double typePrice, string isAddBed, double addBedPrice, string remark)
        {
            this.TypeId = typeId;
            this.TypeName = typeName;
            this.TypePrice = typePrice;
            this.IsAddBed = isAddBed;
            this.AddBedPrice = addBedPrice;
            this.Remark = remark;
        }
        private string remark;

        public string Remark
        {
            get { return remark; }
            set { remark = value; }
        }
        private double addBedPrice;

        public double AddBedPrice
        {
            get { return addBedPrice; }
            set { addBedPrice = value; }
        }
        private string isAddBed;

        public string IsAddBed
        {
            get { return isAddBed; }
            set { isAddBed = value; }
        }
        private double typePrice;

        public double TypePrice
        {
            get { return typePrice; }
            set { typePrice = value; }
        }
        private string typeName;

        public string TypeName
        {
            get { return typeName; }
            set { typeName = value; }
        }
        private int typeId;

        public int TypeId
        {
            get { return typeId; }
            set { typeId = value; }
        }
    }
}
