import {
  TouchableOpacity,
  View,
  Text,
  Image,
  ActivityIndicator,
} from "react-native"
import { AntDesign } from "@expo/vector-icons"

const background = require("../../../assets/images/QrBg-transformed.png")
const photoGallery = require("../../../assets/images/photo-gallery.png")
const qrContainer = require("../../../assets/images/QrContainer.jpg")
const Logo = require("../../../assets/images/Logo-transparent.png")
import { useLocalSearchParams } from "expo-router"

import { Feather } from "@expo/vector-icons"
import { useEffect, useState } from "react"

import * as checkServices from "../../apiServices/checkServices"

const QRCodeScreen = () => {
  const { qrImageUrl, eventId } = useLocalSearchParams()
  const [imageUrl, setImageUrl] = useState(qrImageUrl)

  const handleGenQR = async () => {
    const response = await checkServices
      .genQR(eventId, {
        Id: eventId,
      })
      .catch((error) => {
        console.log(error.response.data)
      })

    if (response) {
      console.log(response)
      setImageUrl(response.qrImageUrl)
    }
  }

  useEffect(() => {
    console.log(imageUrl)
    if (imageUrl === undefined || imageUrl === "" || imageUrl === null) {
      handleGenQR()
    }
  }, [])

  return (
    <View className='flex-1 bg-white '>
      <Image
        source={qrContainer}
        className='absolute h-full w-full  transform opacity-60'
        style={{ resizeMode: "cover" }}
      ></Image>
      <View className='absolute mt-4 w-full flex-row items-center pl-3'>
        <TouchableOpacity>
          <AntDesign name='arrowleft' size={28} color='#333' />
        </TouchableOpacity>
        <Text className='ml-1 text-2xl font-semibold text-[#333]'>
          {" "}
          QR điểm danh
        </Text>
      </View>
      <View className='flex-1 items-center justify-center'>
        <View className='h-[70%] w-[80%] items-center justify-center'>
          <Image
            source={background}
            className='absolute h-full w-full rounded-3xl '
          ></Image>
          <View className='absolute top-9 h-[80] w-[80]'>
            <Image source={Logo} className='absolute h-full w-full' />
          </View>
          <View className='h-[250px] w-[250px] justify-center rounded-lg bg-white shadow-md shadow-slate-800'>
            {imageUrl !== undefined ? (
              <Image
                className='h-full w-full'
                source={{ uri: imageUrl }}
              ></Image>
            ) : (
              <ActivityIndicator size='large' color='#0284D9' />
            )}
          </View>
        </View>
      </View>

      <View className='absolute bottom-0 h-[180] w-full items-center bg-white pt-5'>
        <TouchableOpacity className='items-center justify-center'>
          <Feather name='image' size={40} color='#0284D9' />
          <Text className='text-base font-semibold'>Lưu vào thư viện</Text>
        </TouchableOpacity>
      </View>
    </View>
  )
}

export default QRCodeScreen
