namespace RGR
{
    using System;
    using System.Data.SqlClient;

    public class Changing : Request
    {
        private PlantTable model = new PlantTable(); //Поле-кортеж базы данных
        public Changing(string Name, string Category, string Author, string ParentVariety, string Productivity,
            string FrostResistance, string PestResistance, string DiseaseResistance, Int32 CustID)
        {
            model.CustomID = CustID;
            model.Name = Name; //Название сорта
            model.Category = Category; //Категория сорта
            model.Author = Author; //Автор сорка

            if (ParentVariety.Length != 0) //Проверка на пустое поле
                model.ParentVariety = Convert.ToInt32(ParentVariety); //Индекс родительского сорта

            if (Productivity.Length != 0) //Проверка на пустое поле
                model.Productivity = Convert.ToInt32(Productivity); //Урожайность

            if (FrostResistance.Length != 0) //Проверка на пустое поле
                model.FrostResistance = Convert.ToInt32(FrostResistance); //Морозостойкость

            model.PestResistance = PestResistance.Trim(); //Устойчивость к вредителям
            model.DiseaseResistance = DiseaseResistance.Trim(); //Устойчивость к болезням
        }

        public void change_sort()
        {
            string zs = model.ParentVariety != null ? Convert.ToString(model.ParentVariety) : "NULL";

            string sqlExpression;
            sqlExpression = "UPDATE PlantTable SET Name= '"
                + model.Name + "' , Category= '"
                + model.Category + "' , Author= '"
                + model.Author + "' , ParentVariety="
                + zs + " , Productivity= "
                + model.Productivity + " , FrostResistance= "
                + model.FrostResistance + " , PestResistance= '"
                + model.PestResistance + "' , DiseaseResistance= '"
                + model.DiseaseResistance + "' WHERE CustomID= '" + model.CustomID + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                int number = command.ExecuteNonQuery();
                Console.WriteLine("Обновлено объектов: {0}", number);
            }
        }
    }
}
