using Core.Entities.Abstract;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.Json
{
    public class JsonEntityBaseRepository<TEntity> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()

    {
        private static readonly string jsonPath = @"D:\C#&Angular-Kamp\MapProject\DataAccess\Concrete\Json\MapJson.json";
        public void Add(TEntity entity)
        {

            string jsonData = File.ReadAllText(jsonPath);
            List<TEntity> tEntities = JsonConvert.DeserializeObject<List<TEntity>>(jsonData);

            int maxId=tEntities.Max(p => p.Id);
            entity.Id = maxId+1;
            tEntities.Add(entity);

            string newJsonData = JsonConvert.SerializeObject(tEntities, Formatting.Indented);

            File.WriteAllText(jsonPath, newJsonData);


        }

        public void Delete(TEntity entity)
        {
            string jsonData = File.ReadAllText(jsonPath);
            List<TEntity> tEntities = JsonConvert.DeserializeObject<List<TEntity>>(jsonData);

            TEntity deletedEntity = tEntities.SingleOrDefault(e => e.Id == entity.Id);

            if (deletedEntity !=null)
            {
                tEntities.Remove(deletedEntity);
            }

            string newJsonData = JsonConvert.SerializeObject(tEntities, Formatting.Indented);

            File.WriteAllText(jsonPath, newJsonData);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {

            return null;
        }

        public TEntity Get(int id)
        {
            string jsonData = File.ReadAllText(jsonPath);
            List<TEntity> tEntities = JsonConvert.DeserializeObject<List<TEntity>>(jsonData);

            return tEntities.SingleOrDefault(e => e.Id == id);
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (StreamReader streamReader = new StreamReader(jsonPath))
            {
                string json = streamReader.ReadToEnd();
                List<TEntity> tEntities = JsonConvert.DeserializeObject<List<TEntity>>(json);
                return tEntities;
            }
        }

        public void Update(TEntity entity)
        {
            string jsonData = File.ReadAllText(jsonPath);
            List<TEntity> tEntities = JsonConvert.DeserializeObject<List<TEntity>>(jsonData);

            TEntity updatedEntity = tEntities.SingleOrDefault(e => e.Id == entity.Id);

            tEntities.Remove(updatedEntity); 
            
            tEntities.Add(entity);

            string newJsonData = JsonConvert.SerializeObject(tEntities, Formatting.Indented);

            File.WriteAllText(jsonPath, newJsonData);
        }
    }
}
