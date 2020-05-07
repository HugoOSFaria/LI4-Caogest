<template>
    <div id = "faqsadmin" class = "FAQsAdmin">
        <NavbarKennel/>
        <FAQs/>
        <Footer/>
    </div>
</template>


<script>
import NavbarKennel from '@/components/NavbarFooter/NavbarAdmin.vue'
import Footer from '@/components/NavbarFooter/FooterAdmin.vue'
import FAQs from '@/components/Infos/FAQs.vue'
 
export default {
    components: {
                NavbarKennel, 
                Footer,
                FAQs
    }, 
    
}
</script>