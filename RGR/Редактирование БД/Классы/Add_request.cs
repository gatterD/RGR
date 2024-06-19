namespace RGR
{

    using System;
    using System.Data.SqlClient;
    public class Add_request : Request
    {
        private PlantTable model = new PlantTable(); //Поле-кортеж базы данных
        public Add_request(string Name, string Category, string Author, string ParentVariety, string Productivity,
            string FrostResistance, string PestResistance, string DiseaseResistance)
        {
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

        public void adding_new_sort()
        {
            string zs = model.ParentVariety != null ? Convert.ToString(model.ParentVariety) : "NULL";


            string sqlExpression;
            sqlExpression = "INSERT INTO PlantTable (Name, Category, Author, ParentVariety, Productivity, FrostResistance, PestResistance, DiseaseResistance) " +
                    "VALUES ('" + model.Name + "', '" + model.Category + "', '" + model.Author + "', " + zs + ", " + model.Productivity + ", " +
                    "" + model.FrostResistance + ", '" + model.PestResistance + "', '" + model.DiseaseResistance + "')";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                int number = command.ExecuteNonQuery();
                Console.WriteLine("Добавлено объектов: {0}", number);
            }
            Console.Read();
        }
    }
}
