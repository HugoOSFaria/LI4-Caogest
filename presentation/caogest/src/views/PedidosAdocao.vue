<template>
    <div id = "requestkennel" class = "Request Kennel">
        <NavbarAdmin/>
        <v-card flat height = "100"></v-card>
        <PedidosAdocao/>
        <Footer/>
    </div>
</template> 

<script>
import NavbarAdmin from '../components/NavbarAdmin.vue'
import Footer from '../components/Footer.vue'
import PedidosAdocao from '../components/PedidosAdocao.vue'
  export default {
        components: { NavbarAdmin, 
                      Footer, 
                      PedidosAdocao, 
        }
  }
</script>     