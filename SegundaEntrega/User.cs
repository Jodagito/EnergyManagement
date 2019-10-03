using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaEntrega
{
    public class User
    {
        string id_card;
        string stratum;
        float save_goal;
        float actual_consume;
        float incentive_value;

        public User(string id_card, string stratum, float save_goal, float actual_consume)
        {
            this.id_card = id_card;
            this.stratum = stratum;
            this.save_goal = save_goal;
            this.actual_consume = actual_consume;
        }

        public string idCard
        {
            get { return id_card; }
            set { id_card = value; }
        }

        public string Stratum
        {
            get { return stratum; }
            set { stratum = value; }
        }

        public float saveGoal
        {
            get { return save_goal; }
            set { save_goal = value; }
        }

        public float actualConsume
        {
            get { return actual_consume; }
            set { actual_consume = value; }
        }

        public float incentiveValue
        {
            get { return incentive_value; }
            set { incentive_value = value; }
        }

        public float calculateBill(float save_goal, float actual_consume)
        {
            float partial_value = actual_consume * 500;
            incentive_value = (save_goal - actual_consume) * 500;
            float bill_value = partial_value - incentive_value;
            return bill_value;
        }

        public bool consumeBiggerThanGoal()
        {
            if (save_goal < actual_consume)
            {
                return true;
            }
            return false;
        }
    }

    public struct Users
    {
        List<User> registered_users;

        public Users(List<User> registered_users)
        {
            this.registered_users = registered_users;
        }

        public List<User> registeredUsers
        {
            get { return registered_users; }
            set { registered_users = value; }
        }

        public float calculateConsumeAverage()
        {
            float consume_average;
            float consume_accumulate = 0;
            foreach (User user in registered_users)
            {
                consume_accumulate += user.actualConsume;
            }
            consume_average = consume_accumulate / registered_users.Count();
            return consume_average;
        }

        public float calculateTotalIncentives()
        {
            float total_incentive = 0;
            foreach (User user in registered_users)
            {
                float incentive_value = user.incentiveValue;
                if (incentive_value > 0)
                {
                    total_incentive += incentive_value;
                }
            }
            return total_incentive;
        }

        public float savePercentagePerStratum(string stratum)
        {
            float save_percentage;
            float consumes_accumulator = 0;
            float save_goals_accumulator = 0;
            foreach (User user in registered_users)
            {
                if (!user.consumeBiggerThanGoal())
                {
                    consumes_accumulator += user.actualConsume;
                    save_goals_accumulator += user.saveGoal;
                }
            }
            save_percentage = (consumes_accumulator / save_goals_accumulator);
            save_percentage *= 100;
            return save_percentage;
        }

        public int consumeBiggerThanGoal()
        {
            int users_with_consume_grater_than_goal = 0;
            foreach (User user in registered_users)
            {
                if (user.consumeBiggerThanGoal())
                {
                    users_with_consume_grater_than_goal++;
                }
            }
            return users_with_consume_grater_than_goal;
        }
    }
}
