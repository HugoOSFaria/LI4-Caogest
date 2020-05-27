const lhost = require("@/config/global").host;
import axios from "axios";

import {Pie} from "vue-chartjs";

export default {
  extends: Pie,
  data() {
    return {
      info: {
        labels: [
          "Aceites",
          "Pendentes",
          "Rejeitados",
        ],
        datasets: [
          {
            backgroundColor: [
              "#C5E1A5",
              "#FFE082",
              "#EF9A9A",
            ],
            data: [0, 0, 0]
          }
        ]
      },
      options: {
        responsive: true,
        maintainAspectRatio: false
      }
    };
  },
  async mounted() {
    await axios.get(lhost + "/api/Stats/Estado")
      .then(res => {
        this.info.datasets[0].data[0] = res.data[0];

        this.info.datasets[0].data[1] = res.data[1];

        this.info.datasets[0].data[2] = res.data[2];

        this.renderChart(this.info, this.options);
        

      })
      .catch(error => console.log(JSON.stringify(error)));
  }
};