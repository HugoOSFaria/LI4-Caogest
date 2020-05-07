<template>
  <div>
    <Navbar/>
    <PedidosAdocao :id="$route.params.id"/>
    <Footer/>
  </div>
</template>

<script>
// @ is an alias to /src
import PedidosAdocao from '@/components/PedidosAdocao.vue'
import Navbar from '@/components/NavbarFooter/NavbarAdmin.vue'
import Footer from '@/components/NavbarFooter/FooterAdmin.vue'
export default {
  name: 'PedidoAdocaoAdmin',
  components: {
    PedidosAdocao,
    Navbar, 
    Footer
  }
}
</script>