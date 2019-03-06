using Post.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Post.Web.DAL
{
    public class ReviewSqlDal : IReviewDAL
    {
        private readonly string connectionString;

        public ReviewSqlDal(string connectionString)
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        /// Returns a list of all reviews
        /// </summary>
        /// <returns></returns>
        public IList<Review> GetAllReviews()
        {
            IList<Review> reviews = new List<Review>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM reviews", conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    reviews.Add(MapRowToReview(reader));
                }
            }

            return reviews;
        }

        /// <summary>
        /// Saves a new review to the system.
        /// </summary>
        /// <param name="newReview"></param>
        /// <returns></returns>
        public int SaveReview(Review newReview)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = $"INSERT INTO reviews (username, rating, review_title, review_text) VALUES (@username, @rating, @review_title, @review_text); SELECT CAST(SCOPE_IDENTITY() as int);";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", newReview.Username);
                cmd.Parameters.AddWithValue("@rating", newReview.Rating);
                cmd.Parameters.AddWithValue("@review_title", newReview.ReviewTitle);
                cmd.Parameters.AddWithValue("@review_text", newReview.ReviewText);

                return (int)cmd.ExecuteScalar();
            }
        }

        private Review MapRowToReview(SqlDataReader reader)
        {
            return new Review()
            {
                Rating = Convert.ToInt32(reader["rating"]),
                ReviewText = Convert.ToString(reader["review_text"]),
                ReviewTitle = Convert.ToString(reader["review_title"]),
                Username = Convert.ToString(reader["username"])
            };
        }
    }
}
