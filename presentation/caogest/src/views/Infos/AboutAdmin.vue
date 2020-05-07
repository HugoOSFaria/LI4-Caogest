<template>
    <div id = "about" class = "About">
        <NavbarKennel/>
        
        <About/>
          
        <Footer/>
    </div>
</template>

<script>
import NavbarKennel from '@/components/NavbarFooter/NavbarAdmin.vue'
import Footer from '@/components/NavbarFooter/FooterAdmin.vue'
import About from '@/components/Infos/About.vue'
export default {
    components: {   NavbarKennel, 
                    Footer,
                    About }
}
</script>