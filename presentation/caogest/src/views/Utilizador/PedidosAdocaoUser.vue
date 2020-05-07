<template>
    <div id = "requestkennel" class = "Request Kennel">
        <Navbar/>
        <v-card flat height = "100"></v-card>
        <PedidosAdocao/>
        <Footer/>
    </div>
</template> 

<script>
import Navbar from '@/components/NavbarFooter/Navbar.vue'
import Footer from '@/components/NavbarFooter/Footer.vue'
import PedidosAdocao from '@/components/PedidosAdocao.vue'
  export default {
        components: { Navbar, 
                      Footer, 
                      PedidosAdocao, 
        }
  }
</script>     