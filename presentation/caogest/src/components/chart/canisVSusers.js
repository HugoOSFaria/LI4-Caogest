const lhost = require("@/config/global").host;
import axios from "axios";

import {Pie} from "vue-chartjs";

export default {
  extends: Pie,
  data() {
    return {
      info: {
        labels: [
          "Canil",
          "Utilizadores",
        ],
        datasets: [
          {
            backgroundColor: [
              "#FFE082",
              "#C5E1A5",

            ],
            data: [0, 0]
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
    await axios.get(lhost + "/api/Users")
      .then(res => {
        for (var i = 0; i < res.data.length; i++) {
          if(res.data[i].tipo === 1)
          this.info.datasets[0].data[1] += 1;

          if(res.data[i].tipo === 2)
          this.info.datasets[0].data[0] += 1;
        }
        this.renderChart(this.info, this.options);
      })
      .catch(error => console.log(JSON.stringify(error)));
  }
};
