import {
  Text,
  View,
  TouchableOpacity,
  Image,
  ActivityIndicator,
  Pressable,
} from "react-native"
import React, { memo, useEffect, useState } from "react"
import { SliderBox } from "react-native-image-slider-box"
import { Entypo } from "@expo/vector-icons"
import { Link } from "expo-router"
import { format } from "date-fns"
const EventItem = memo(({ item }) => {
  // const slides = [
  //   "https://thanhnien.mediacdn.vn/thumb_w/750/325084952045817856/2023/3/20/base64-16792880739381319994436.jpeg",
  //   "https://tuyensinh.uit.edu.vn/sites/default/files/uploads/images/202310/2b7173db-6933-4f88-b227-ebf0e042c41e.png",
  //   "https://www.uit.edu.vn/sites/vi/files/image_from_word/hoc_bong_khoa_khoa_hoc_may_tinh_7.jpg",
  //   "https://www.uit.edu.vn/sites/vi/files/image_from_word/u.jpg",
  // ]

  const [slides, setSlides] = useState([])
  useEffect(() => {
    let array = []

    for (let image of item.images) array.push(image.imageUrl)

    setSlides(array)
  }, [])
  return (
    <View
      className='m-2 max-h-fit rounded border-[1px] border-gray-100 
        bg-white p-3 shadow-sm shadow-gray-600'
    >
      <Link href={{ pathname: "(page)/page-detail/[id]", params: { id: 1 } }}>
        <View className='flex-row items-center'>
          <View className='h-10 w-10 rounded-full border-[1px] border-gray-400'>
            <Image
              className='h-full w-full rounded-full'
              source={{
                uri: "https://scontent.fsgn19-1.fna.fbcdn.net/v/t39.30808-1/305532054_516142960436144_1879050775822715016_n.png?stp=dst-png_p200x200&_nc_cat=100&ccb=1-7&_nc_sid=f4b9fd&_nc_eui2=AeEtgxD_Bswpplegl9oYgrNXCjcq6jLgDwAKNyrqMuAPAA8VBEbD5DmuSeAffO0Bth9bL7Ql3VcN1c7nMxzUZaFh&_nc_ohc=ZipIcHJDvIwQ7kNvgH6gMdM&_nc_ht=scontent.fsgn19-1.fna&oh=00_AYB3HC2i_baSELXRppIi7T0-6DnEf_5FUbW5e2h4cy50iA&oe=66822370",
              }}
            ></Image>
          </View>

          <View className='ml-2 max-w-[180px] justify-center'>
            <Text
              numberOfLines={1}
              ellipsizeMode='tail'
              lineBreakMode='tail'
              className='text-base font-semibold'
            >
              Ban học tập khoa Kỹ Thuật Phần Mềm
            </Text>
            <Text className='text-xs'>12:20 - 25/05/2024</Text>
          </View>

          <View className='flex-1 items-end justify-center'>
            {/* <Text className='text-sm font-medium text-red-500'>Kết thúc</Text> */}
            <Text className='text-sm font-medium text-green-500'>
              Đang diễn ra
            </Text>
            {/* <Text className='text-sm font-medium text-orange-500'>
              Chưa bắt đầu
            </Text> */}
            <Text className='text-xs'>50/120</Text>
          </View>
        </View>
      </Link>

      <View className='mt-2'>
        <Text
          className='text-base font-medium'
          numberOfLines={2}
          ellipsizeMode='tail'
        >
          ☀️ [{item.title}] ☀️
        </Text>
        <Text numberOfLines={5} ellipsizeMode='tail'>
          🤗 {item.description}
        </Text>
        <Link href={"detail/EventDetail"}>
          <Text className='text-blue-500'>Xem thêm</Text>
        </Link>
      </View>

      <View className='mt-2 max-h-[200px] items-center justify-center'>
        <SliderBox
          images={slides}
          dotColor='#FFFFFF'
          inactiveDotColor='#F5F5F5'
          ImageComponentStyle={{ borderRadius: 5, width: "80%" }}
          imageLoadingColor='#3A57E8'
        />
      </View>

      <View className='my-3 h-[0.5px] w-full bg-gray-300'></View>

      <View className='flex-row justify-between'>
        <TouchableOpacity className='rounded bg-blue-500 px-5 py-2'>
          <Entypo name='link' size={20} color='white' />
        </TouchableOpacity>

        {/* bg-slate-400 */}
        {
          <TouchableOpacity className='rounded bg-blue-500 px-5 py-2'>
            <Text className='font-medium text-white'>Đăng ký</Text>
            {/* <Text className='font-medium text-white'>Đã đăng ký</Text> */}
            {/* <ActivityIndicator size='small' color='#ffffff' /> */}
          </TouchableOpacity>
        }
      </View>
    </View>
  )
})

export default EventItem
