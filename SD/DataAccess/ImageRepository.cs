using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace DataAccess
{
    public class ImageRepository: ConnectionClass
    {
        UserRepository uRep = new UserRepository();
        public void addImage(string url, string desc, int userId)
        {
            bool userIDExists = false;
            #region if statements

            if (uRep.checkIfUserIdExists(userId))
            {
                userIDExists = true;
            }
            #endregion
            Image img = new Image();
            img.ImageURL = url;
            img.ImageDescription = desc;
            
            entities.Images.Add(img);
            entities.SaveChanges();
        }
        public Image getImage(int id)
        {
            return entities.Images.SingleOrDefault(x => x.ImageId == id);
        }
    }
}
