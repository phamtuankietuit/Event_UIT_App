import React from "react"
import { View } from "react-native"
import { SliderBox } from "react-native-image-slider-box"

const Carousel = () => {
  const slides = [
    "https://thanhnien.mediacdn.vn/thumb_w/750/325084952045817856/2023/3/20/base64-16792880739381319994436.jpeg",
    "https://tuyensinh.uit.edu.vn/sites/default/files/uploads/images/202310/2b7173db-6933-4f88-b227-ebf0e042c41e.png",
    "https://www.uit.edu.vn/sites/vi/files/image_from_word/hoc_bong_khoa_khoa_hoc_may_tinh_7.jpg",
    "https://www.uit.edu.vn/sites/vi/files/image_from_word/u.jpg",
  ]

  return (
    <View className='mb-3 flex min-h-[200px] flex-1 items-center justify-center'>
      <SliderBox
        images={slides}
        dotColor='#FFFFFF'
        inactiveDotColor='#F5F5F5'
        ImageComponentStyle={{ borderRadius: 15, width: "90%" }}
        autoplay={true}
        circleLoop
        autoplayInterval={3000}
        imageLoadingColor='#3A57E8'
      />
    </View>
  )
}

export default Carousel
