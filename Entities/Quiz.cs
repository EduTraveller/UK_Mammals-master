
/* <summary>
   Represents a Quiz entity with a unique identifier.
   Author: Eduardo
   Last Modified: 25/07/2024
*/

using System.ComponentModel.DataAnnotations; // Import DataAnnotations for validation and metadata

namespace UK_Mammals.Entities
{
    // Represents a Quiz entity
    public class Quiz
    {
        // Unique identifier for the Quiz ID
        // This ID is used to uniquely identify each quiz instance
        public int QuizID { get; set; }
    }
}

// Author: Eduardo
// Last Modified: 22/07/2024
