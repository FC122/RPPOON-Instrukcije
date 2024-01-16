namespace DIPPrimjer
{
    public class DataAccessLayer
    { 
        public string GetData() {
            return "Podatci iz baze";
	    }
    }

    public class BusinessLogicLayer {
        private DataAccessLayer dataAccess;

        public BusinessLogicLayer()
        {
            this.dataAccess = new DataAccessLayer();
        }

        public string ProcessData() {
            return this.dataAccess.GetData();
	    }
    }

}

