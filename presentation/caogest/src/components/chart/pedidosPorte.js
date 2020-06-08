import axios from 'axios'
const lhost = require("@/config/global").host;
import { Pie } from "vue-chartjs";

export default {
  extends: Pie,
  data() {
    return {
      info: {
        labels: [
            "Pequeno",
            "Medio",
            "Grande",

        ],
        datasets: [
          {
            backgroundColor: [
              "#C5E1A5",
              "#B39DDB",
              "#EF9A9A",
            ],
            data: [0, 0, 0]
          }
        ]
      },
      options: {
        responsive: true,
        maintainAspectRatio: false,
        legend: {
          display: true,
          labels: {
              fontSize:20,
          }
        }
      }
    };
  },
  async mounted() {
    await axios.get(lhost + "/api/Stats/Pedidos/Cao")
      .then(res => {
            this.info.datasets[0].data[0] = res.data[0];
            this.info.datasets[0].data[1] = res.data[1];
            this.info.datasets[0].data[2] = res.data[2];
        
        this.renderChart(this.info, this.options);
      })
      .catch(error => console.log(JSON.stringify(error)));
  }
};
