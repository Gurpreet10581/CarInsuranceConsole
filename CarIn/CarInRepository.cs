using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarIn
{
    public class CarInRepository
    {
        List<CarInContent> _contentDirectory = new List<CarInContent>();
        public bool AddContentToDirectory(CarInContent content)
        {
            int startingCount = _contentDirectory.Count;
            _contentDirectory.Add(content);
            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;

        }

        public List<CarInContent> GetContents()
        {
            return _contentDirectory;
        }

        public CarInContent GetContentByLastName(string lastname)
        {
            foreach (CarInContent content in _contentDirectory)
            {
                if (content.LastName.ToLower() == lastname.ToLower())
                {
                    return content;
                }

            }
            return null;
        }

        public bool UpdateExistingContent(string originalLastName, CarInContent updatedContent)
        {
            CarInContent oldContent = GetContentByLastName(originalLastName);
            if (oldContent != null)
            {
                oldContent.Id = updatedContent.Id;
                oldContent.LastName = updatedContent.LastName;
                oldContent.Age = updatedContent.Age;
                oldContent.EnrollmentDate = updatedContent.EnrollmentDate;
                oldContent.TypeOfMembership = updatedContent.TypeOfMembership;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeleteExistingContent(CarInContent carInContent)
        {
            bool deleteResult = _contentDirectory.Remove(carInContent);
            return deleteResult;
        }

    }
}
