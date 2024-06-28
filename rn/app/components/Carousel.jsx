import { useEffect, useState } from "react"
import { View, ToastAndroid, ActivityIndicator } from "react-native"
import { SliderBox } from "react-native-image-slider-box"

import * as eventServices from "../apiServices/eventServices"

const showToastWithGravity = (msg) => {
  ToastAndroid.showWithGravity(msg, ToastAndroid.SHORT, ToastAndroid.CENTER)
}

const Carousel = () => {
  const [events, setEvents] = useState(null)
  const [loading, setLoading] = useState(false)
  const [slides, setSlides] = useState(null)

  const handleOnPress = (index) => {
    console.log(events[index].id)
  }

  const getHotEvents = async () => {
    console.log("run")
    const response = await eventServices.getHotEvents().catch((error) => {
      showToastWithGravity("Có lỗi xảy ra")
    })

    if (response) {
      console.log(response)
      setEvents(response.events.items)
      setSlides(response.events.items.map((item) => item.images[0].imageUrl))
    }
  }

  useEffect(() => {
    getHotEvents()
  }, [])

  return (
    <View
      className={`${slides === null && "bg-white"} mb-3 flex min-h-[200px] flex-1 items-center justify-center`}
    >
      {slides === null ? (
        <ActivityIndicator size='large' color='#3A57E8' />
      ) : (
        <SliderBox
          images={slides}
          dotColor='#FFFFFF'
          inactiveDotColor='#F5F5F5'
          ImageComponentStyle={{ borderRadius: 15, width: "90%" }}
          autoplay={true}
          circleLoop
          autoplayInterval={3000}
          imageLoadingColor='#3A57E8'
          onCurrentImagePressed={handleOnPress}
        />
      )}
    </View>
  )
}

export default Carousel
