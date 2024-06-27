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
      <TouchableOpacity
        className='flex-row items-center'
        onPress={() => {
          router.push("(page)/page-detail")
        }}
      >
        <View className='h-10 w-10 rounded-full border-[1px] border-gray-400'>
          <Image
            className='h-full w-full rounded-full'
            source={{
              uri: item.universityUnit.avatarUrl,
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
            {item.universityUnit.name}
          </Text>
          <Text className='text-xs'>{format(item.publishedDate, "HH:mm - dd/MM/yyyy ")}</Text>
        </View>

        <View className='flex-1 items-end'>
          {/* <Text className='text-sm font-medium text-red-500'>Kết thúc</Text> */}
          <Text className='text-sm font-medium text-green-500'>
            Đang diễn ra
          </Text>
          {/* <Text className='text-sm font-medium text-orange-500'>
            Chưa bắt đầu
          </Text> */}
          <Text className='text-xs'>{item.totalRegistration}/{item.maxAttendees}</Text>
        </View>
      </TouchableOpacity>

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
